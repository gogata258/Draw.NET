using System.Drawing;

namespace Draw.Primitives
{
	public class Triangle : ShapeBase
	{
		public Triangle( ShapeBase shape, string name ) : base( shape, name ) { }
		public Triangle( float X, float Y, float width, float height, string name ) : base( X, Y, width, height, name ) { }

		private PointF[] Points => new PointF[]
		{
			new PointF(ObjectLocX + (ObjectWidth/2), ObjectLocY),
			new PointF(ObjectLocX + ObjectWidth, ObjectLocY + ObjectHeight),
			new PointF(ObjectLocX, ObjectLocY+ObjectHeight)
		};
		public override void DrawSelf( Graphics grfx )
		{
			grfx.RotateTransform( Rotation );
			grfx.DrawPolygon( new Pen( BorderColor, BorderThickness ), Points );
			grfx.FillPolygon( new SolidBrush( FillColor ), Points );
			grfx.RotateTransform( -Rotation );
		}
	}
}
