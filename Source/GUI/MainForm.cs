using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Draw.GUI
{
	using Primitives;
	using Primitives.Components;
	using Processors;
	using Utilities;

	public partial class MainForm : Form
	{
		private const string FILE_EXTENSION_JSON = ".json";
		private const string FILE_EXTENSION_PNG = ".png";

		private DialogProcessor dialogProcessor;
		private List<ToolStripButton> manipulationTools;
		private Dictionary<TextBox, string> propertyDict;
		private System.Timers.Timer timer;
		private bool isUpdatingUI;

		public MainForm()
		{
			InitializeComponent( );

			ShapeBase tempShape = new Empty("temp");
			propertyDict = new Dictionary<TextBox, string>( )
			{
				{ scaleYTextBox, nameof(tempShape.ScaleY) },
				{ scaleXTextBox,nameof(tempShape.ScaleX) },
				{ LocXTextbox, nameof(tempShape.LocationX) },
				{ LocYTextbox,nameof(tempShape.LocationY) },
				{ borderThicknessTextbox, nameof(tempShape.BorderThickness) },
				{ borderColorATextbox, nameof(tempShape.BorderColor_A) },
				{ borderColorRTextbox,nameof(tempShape.BorderColor_R) },
				{ borderColorGTextbox, nameof(tempShape.BorderColor_G) },
				{ borderColorBTextbox, nameof(tempShape.BorderColor_B) },
				{ fillColorATextbox, nameof(tempShape.FillColor_A) },
				{ fillColorRTextbox, nameof(tempShape.FillColor_R) },
				{ fillColorGTextbox, nameof(tempShape.FillColor_G) },
				{ fillColorBTextbox, nameof(tempShape.FillColor_B) },
				{ nameTextbox, nameof(tempShape.Name)},
				{ rotationTextbox, nameof(tempShape.Rotation)}
			};

			timer = new System.Timers.Timer(17)
			{
				AutoReset = false
			};

			dialogProcessor = new DialogProcessor( );
			manipulationTools = new List<ToolStripButton>( );
			OnUIUpdate( );
			SetManipulationTools( );
		}

		private void SetManipulationTools()
		{
			manipulationTools.Add(quickAction_Toggle_Move);
			manipulationTools.Add(quickAction_Toggle_Select);
			manipulationTools.Add(quickAction_Toggle_Rotate);
			manipulationTools.Add(quickAction_Toggle_Scale);
		}

		private void OnUIUpdate()
		{
			if (!timer.Enabled)
			{
				isUpdatingUI = true;

				UpdateHierarchyItems( );
				SetHierarchySelection( );
				UpdateTextboxValues( );

				isUpdatingUI = false;

				timer.Start( );
			}
		}

		private void UpdateHierarchyItems()
		{
			hierarchyListbox.Items.Clear( );
			dialogProcessor.DisplayProcessor.Shapes.ForEach(s => AddShapeToListbox(s, 0));
			hierarchyListbox.DisplayMember = "Name";
			hierarchyListbox.ValueMember = "Id";
		}

		private void UpdateTextboxValues()
		{
			ShapeBase shape = dialogProcessor.MultiSelection.FirstOrDefault();

			if (shape is null)
				propertyDict.ToList( ).ForEach(tb => tb.Key.Text = string.Empty);
			else
				foreach (PropertyInfo prop in shape.GetType( ).GetProperties( ))
					if (propertyDict.Any(p => p.Value == prop.Name))
					{
						KeyValuePair<TextBox, string> dictItem = propertyDict.FirstOrDefault(p => p.Value == prop.Name);
						dictItem.Key.Text = prop.GetValue(shape).ToString( );
					}

		}

		private void SetHierarchySelection()
		{
			List<ShapeBase> selectedItems = dialogProcessor.MultiSelection;
			for (int i = 0; i < hierarchyListbox.Items.Count; i++)
			{
				object item = hierarchyListbox.Items[i];
				if (selectedItems.Any(s => s.Id.ToString( ) == GetIdFromListboxItem(item)))
					hierarchyListbox.SetSelected(i, true);
				else hierarchyListbox.SetSelected(i, false);
			}
		}

		private void AddShapeToListbox(ShapeBase shape, int tabs)
		{
			if (shape is Group g)
			{
				hierarchyListbox.Items.Add(GetListBoxItem(g, tabs));
				g.Shapes.ToList( ).ForEach(s => AddShapeToListbox(s, tabs + 1));
			}
			else hierarchyListbox.Items.Add(GetListBoxItem(shape, tabs));
		}

		private static object GetListBoxItem(ShapeBase s, int tabs) => new { Name = $"{new string('\t', tabs)}{s.Name}", Id = s.Id.ToString( ) };
		private static string GetIdFromListboxItem(object item) => (string) item.GetType( ).GetProperty("Id").GetValue(item);
		private void DeleteSelection()
		{
			dialogProcessor.MultiSelection.ForEach(s => dialogProcessor.DeleteShape(dialogProcessor.DisplayProcessor.Shapes, s));
			viewPort.Invalidate(OnUIUpdate);
		}

		private int GetViewportWidth() => viewPort.Width;
		private int GetViewportHeight() => viewPort.Height;


		#region Other Control Handlers
		private void PropertyTextBox_TextChanged(object sender, EventArgs e)
		{
			if (dialogProcessor.MultiSelection.Any( ) && sender is TextBox tb && !isUpdatingUI)
			{
				KeyValuePair<TextBox, string> kvp = propertyDict.FirstOrDefault(x => x.Key.Name == tb.Name);
				string propName = kvp.Value;
				PropertyInfo prop = dialogProcessor.MultiSelection.First().GetType().GetProperty(propName);

				foreach (ShapeBase shape in dialogProcessor.MultiSelection)
				{
					object value = null;
					try
					{
						value = Convert.ChangeType(tb.Text, prop.PropertyType);
					}
					catch (Exception)
					{
						value = 0;
					}
					prop.SetValue(shape, value);
				}
				viewPort.Invalidate(OnUIUpdate);
			}
		}

		private void HierarchySelectionChanged(object sender, EventArgs e)
		{
			if (sender is ListBox lb && !isUpdatingUI)
			{
				var ids = new List<string>();
				for (int i = 0; i < lb.SelectedItems.Count; i++)
				{
					object item = lb.SelectedItems[i];
					ids.Add(GetIdFromListboxItem(item));
				}
				if (!ids.All(i => dialogProcessor.MultiSelection.Any(s => s.Id.ToString( ) == i)))
				{
					dialogProcessor.SetSelectionFromHierarchy(ids);
					viewPort.Invalidate(OnUIUpdate);
				}
			}
		}

		#endregion

		#region ToolStrip Menu Handlers
		private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e) => Close( );
		private void ToolStripMenuItem_Load_Click(object sender, EventArgs e)
		{
			DialogResult resut = dialogOpen.ShowDialog( );
			if (resut == DialogResult.OK)
			{
				string selectedFileName = dialogOpen.FileName;
				if (File.Exists(selectedFileName))
				{
					dialogProcessor.DisplayProcessor.SetShapes(Serialization.DeserializeShapes(JsonConvert.DeserializeObject<List<JToken>>(File.ReadAllText(selectedFileName))));
					viewPort.Invalidate(OnUIUpdate);
				}
				else
					MessageBox.Show("invalid filename", "Error", MessageBoxButtons.OK);
			}
		}

		private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
		{
			DialogResult resut = dialogSave.ShowDialog( );
			if (resut == DialogResult.OK)
			{
				string fixedFilePath = dialogSave.FileName.Split( new [] {'.'}, StringSplitOptions.RemoveEmptyEntries ).FirstOrDefault();
				if (!string.IsNullOrWhiteSpace(fixedFilePath))
				{
					fixedFilePath += FILE_EXTENSION_JSON;
					File.WriteAllText(fixedFilePath, Serialization.SerializeShapes(dialogProcessor.DisplayProcessor.Shapes));
				}
				else
					MessageBox.Show("invalid filename", "Error", MessageBoxButtons.OK);
			}
		}

		private void ToolStripMenuItem_Export_Click(object sernder, EventArgs e)
		{
			DialogResult resut = dialogExport.ShowDialog( );
			if (resut == DialogResult.OK)
			{
				string fixedFilePath = dialogExport.FileName.Split( new [] {'.'}, StringSplitOptions.RemoveEmptyEntries ).FirstOrDefault();
				if (!string.IsNullOrWhiteSpace(fixedFilePath))
				{
					fixedFilePath += FILE_EXTENSION_PNG;
					using (var bitmap = new Bitmap(GetViewportWidth( ), GetViewportHeight( )))
					{
						viewPort.DrawToBitmap(bitmap, viewPort.Bounds);
						bitmap.Save(fixedFilePath, ImageFormat.Png);
					}
				}
				else
					MessageBox.Show("invalid filename", "Error", MessageBoxButtons.OK);
			}
		}
		#endregion

		#region SpeedButton Handlers
		private void DrawShape_Finalize() => viewPort.Invalidate(OnUIUpdate);

		private void SpeedButton_Draw_Rectangle_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddShape<Primitives.Rectangle>(GetViewportWidth( ), GetViewportHeight( ));
			DrawShape_Finalize( );
		}


		private void SpeedButton_Draw_Triangle_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddShape<Triangle>(GetViewportWidth( ), GetViewportHeight( ));
			DrawShape_Finalize( );
		}

		private void SpeedButton_Draw_Elipse_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddShape<Elipse>(GetViewportWidth( ), GetViewportHeight( ));
			DrawShape_Finalize( );
		}

		private void SpeedButton_Group_Click(object sender, EventArgs e)
		{
			if (dialogProcessor.MultiSelection.Count > 0)
			{
				dialogProcessor.GroupObjects( );
				DrawShape_Finalize( );
				viewPort.Invalidate(OnUIUpdate);
			}
		}

		private void SpeedButton_UnGroup_Click(object sender, EventArgs e)
		{
			if (dialogProcessor.MultiSelection.Count > 0)
			{
				dialogProcessor.UngroupObjects( );
				viewPort.Invalidate(OnUIUpdate);
			}
		}

		private void Tools_Clicked(object sender, EventArgs e)
		{
			if (sender is ToolStripButton btn)
			{
				manipulationTools.ForEach(t => t.Checked = false);
				manipulationTools.Find(t => t == btn).Checked = true;
			}
		}

		private void Tools_Move_CheckChanged(object sender, EventArgs e)
		{
			if (sender is ToolStripButton btn)
				dialogProcessor.IsMoving = btn.Checked;
		}

		private void Tools_Rotate_CheckChanged(object sender, EventArgs e)
		{
			if (sender is ToolStripButton btn)
				dialogProcessor.IsRotating = btn.Checked;
		}

		private void Tools_Scale_CheckChanged(object sender, EventArgs e)
		{
			if (sender is ToolStripButton btn)
				dialogProcessor.IsScaling = btn.Checked;
		}

		private void Tools_Select_CheckChanged(object sender, EventArgs e)
		{
			if (sender is ToolStripButton btn)
				dialogProcessor.IsSelecting = btn.Checked;
		}

		private void Tools_Delete_Clicked(object sender, EventArgs e)
		{
			if (sender is ToolStripButton)
				DeleteSelection( );
		}
		#endregion

		#region Viewport Handlers
		private void ViewPort_Paint(object sender, PaintEventArgs e) => dialogProcessor.DisplayProcessor.ReDraw(sender, e);

		private void ViewPort_MouseDown(object sender, MouseEventArgs e)
		{
			if (dialogProcessor.IsMoving)
			{
				dialogProcessor.IsDragging = true;
				dialogProcessor.LastLocation = e.Location;
				viewPort.Invalidate(OnUIUpdate);
			}
		}

		private void ViewPort_MouseClick(object sender, MouseEventArgs e)
		{
			if (dialogProcessor.IsSelecting)
			{
				ShapeBase item = dialogProcessor.ContainsPoint(e.Location);
				if (item != null)
				{
					dialogProcessor.SetSelectionFromViewport(item);
					viewPort.Invalidate(OnUIUpdate);
				}
			}
		}

		private void ViewPort_MouseEnter(object sender, EventArgs e) => viewPort.Focus( );

		private void ViewPort_MouseMove(object sender, MouseEventArgs e)
		{
			if (dialogProcessor.IsMoving && dialogProcessor.IsDragging && dialogProcessor.MultiSelection.Any( ))
			{
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate(OnUIUpdate);
			}
		}

		private void ViewPort_MouseUp(object sender, MouseEventArgs e) => dialogProcessor.IsDragging = false;

		private void ViewPort_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.ShiftKey) dialogProcessor.IsMultiSelecting = true;
		}

		private void ViewPort_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.ShiftKey) dialogProcessor.IsMultiSelecting = false;
			else if (e.KeyCode == Keys.Delete) DeleteSelection( );
		}
		#endregion
	}
}
