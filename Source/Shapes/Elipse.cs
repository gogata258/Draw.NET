using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw.Shapes
{
	using Abstracts;

	public class Elipse : ShapeBase
	{
		[JsonConstructor] private Elipse() { }
		public Elipse(ShapeBase shape, string name) : base(shape, name, typeof(Elipse).Name) { }
		public Elipse(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(Elipse).Name) { }

		public override void DrawSelf(Graphics grfx)
		{
			var matrix = new Matrix();
			matrix.Translate(LocationX, LocationY);
			matrix.RotateAt(Rotation, MedianPoint);

			//TODO USE THIS INSTEAD
			//grfx.DrawClosedCurve()

			grfx.Transform = matrix;
			grfx.DrawEllipse(new Pen(new SolidBrush(BorderColor)), BorderBoundingBox);
			grfx.FillEllipse(new SolidBrush(FillColor), ObjectBoundingBox);
			base.DrawSelf(grfx);
		}
	}
}
