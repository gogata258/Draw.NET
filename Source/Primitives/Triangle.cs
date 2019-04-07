using Newtonsoft.Json;
using System.Drawing;

namespace Draw.Primitives
{
	public class Triangle : ShapeBase
	{
		[JsonConstructor] private Triangle( ) { }
		public Triangle( ShapeBase shape, string name ) : base( shape, name, typeof( Triangle ).Name ) { }
		public Triangle( float X, float Y, float width, float height, string name ) : base( X, Y, width, height, name, typeof( Triangle ).Name ) { }


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
