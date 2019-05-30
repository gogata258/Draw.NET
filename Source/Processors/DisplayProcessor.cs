using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Draw
{
	using Shapes.Abstracts;

	public class DisplayProcessor
	{
		public DisplayProcessor() => Shapes = new List<ShapeBase>( );

		public List<ShapeBase> Shapes { get; private set; }

		public void ReDraw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Draw(e.Graphics);
		}

		public void Draw(Graphics grfx) => Shapes.ToList( ).ForEach(s => s.DrawSelf(grfx));

		internal void SetShapes(List<ShapeBase> shapes) => Shapes = shapes;
	}
}
