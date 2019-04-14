using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;

namespace Draw.Processors
{
	using Shapes;
	using Shapes.Abstracts;
	using Utilities;

	public class DialogProcessor
	{
		private const int SHAPE_DIMENTION = 100;

		public DialogProcessor()
		{
			DisplayProcessor = new DisplayProcessor( );
			MultiSelection = new List<ShapeBase>( );
		}

		public DisplayProcessor DisplayProcessor { get; set; }
		public bool IsDragging { get; set; }
		public bool IsSelecting { get; set; }
		public bool IsMoving { get; set; }
		public bool IsRotating { get; set; }
		public bool IsScaling { get; set; }
		public bool IsMultiSelecting { get; set; }
		public PointF LastLocation { get; set; }
		public List<ShapeBase> MultiSelection { get; private set; }

		public void AddShape<T>(int width, int height) where T : ShapeBase
		{
			int locationX = (width/2) - (SHAPE_DIMENTION/2);
			int locationY = (height/2) - (SHAPE_DIMENTION/2);

			var shape = (ShapeBase) Activator.CreateInstance(typeof(T), new object[] { locationX, locationY, SHAPE_DIMENTION, SHAPE_DIMENTION, GetName<T>( ) });

			DisplayProcessor.Shapes.Add(shape);
		}

		private string GetName<T>() where T : ShapeBase => typeof(T).Name + DisplayProcessor.Shapes.Where(s => s.GetType( ) == typeof(T)).Count( );

		private ShapeBase FindShape(List<ShapeBase> shapes, string id)
		{
			foreach (ShapeBase item in shapes)
				if (item.Id.ToString( ) == id) return item;
				else if (item is Group g)
				{
					ShapeBase foundShape = FindShape(g.Shapes, id);
					if (foundShape != null) return foundShape;
				}
			return null;
		}

		internal void SetSelectionFromHierarchy(List<string> ids)
		{
			if (ids.Count > 0)
			{
				MultiSelection = new List<ShapeBase>( );
				ids.ForEach(i => MultiSelection.Add(FindShape(DisplayProcessor.Shapes, i)));
				SortMultiSelection( );
			}
		}

		internal void SetSelectionFromViewport(ShapeBase shape)
		{
			if (IsMultiSelecting)
				if (MultiSelection.Any(s => s.Id == shape.Id))
					MultiSelection.Remove(shape);
				else MultiSelection.Add(shape);
			else
				MultiSelection = new List<ShapeBase>( ) { FindShape(DisplayProcessor.Shapes, shape.Id.ToString( )) };

			SortMultiSelection( );
		}

		public void GroupObjects()
		{
			var group = new Group(GetName<Group>(), MultiSelection);
			MultiSelection.ForEach(s => DisplayProcessor.Shapes.Remove(s));
			DisplayProcessor.Shapes.Add(group);
			MultiSelection = new List<ShapeBase>( ) { group };
		}

		public void UngroupObjects()
		{
			var selectedGroups = new List<Group>();
			MultiSelection.ForEach(s => { if (s is Group g) selectedGroups.Add(g); });
			foreach (Group group in selectedGroups)
			{
				group.Shapes.ForEach(s => DisplayProcessor.Shapes.Add(s));
				DisplayProcessor.Shapes.Remove(group);
			}
			SortMultiSelection( );
		}

		private void SortMultiSelection()
		{
			if (MultiSelection.Count > 1) MultiSelection = MultiSelection.OrderBy(s => s.Name).ToList( );
		}

		public void DeleteShape(List<ShapeBase> shapes, ShapeBase shape)
		{
			if (shapes.Any(s => s.Id == shape.Id)) shapes.Remove(shape);
			else shapes.Where(s => s is Group).ToList( ).ForEach(g => DeleteShape(((Group) g).Shapes, shape));
		}

		public ShapeBase ContainsPoint(PointF point)
		{
			foreach (ShapeBase item in DisplayProcessor.Shapes)
			{
				ShapeBase hitTarget = item.Contains(point);
				if (hitTarget != null) return hitTarget;
			}
			return null;
		}

		public void TranslateTo(PointF p)
		{
			MultiSelection.ForEach(s => s.Translate(VectorMath.GetVector(LastLocation, p)));
			LastLocation = p;
		}

		public void Scale(PointF p)
		{
			MultiSelection.ForEach(s => s.Scale(VectorMath.GetVector(LastLocation, p)));
			LastLocation = p;
		}

		public void RotateAngle(PointF p)
		{
			MultiSelection.ForEach(s =>
			{
				Vector startVect = VectorMath.GetVector(s.MedianPoint, LastLocation);
				Vector endVect = VectorMath.GetVector(s.MedianPoint, p);

				float angle = VectorMath.GetAngle(startVect, endVect);
				s.Rotate(angle);
			});

			LastLocation = p;
		}
	}
}
