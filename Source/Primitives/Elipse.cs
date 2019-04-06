using System.Drawing;

namespace Draw.Primitives
{
	public class Elipse : ShapeBase
	{
		public Elipse(ShapeBase shape, string name) : base(shape, name) { }
		public Elipse(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name) { }

		public override void DrawSelf(Graphics grfx)
		{
			grfx.RotateTransform(Rotation);
			grfx.DrawEllipse(new Pen(new SolidBrush(BorderColor)), BorderBoundingBox);
			grfx.FillEllipse(new SolidBrush(FillColor), ObjectBoundingBox);
			grfx.RotateTransform(-Rotation);
		}
	}
}
