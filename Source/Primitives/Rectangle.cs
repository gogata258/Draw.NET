using Newtonsoft.Json;
using System.Drawing;

namespace Draw.Primitives
{
	public class Rectangle : ShapeBase
	{
		[JsonConstructor] private Rectangle( ) { }
		public Rectangle( ShapeBase shape, string name ) : base( shape, name, typeof( Rectangle ).Name ) { }
		public Rectangle( float X, float Y, float width, float height, string name ) : base( X, Y, width, height, name, typeof( Rectangle ).Name ) { }

		public override void DrawSelf( Graphics grfx )
		{
			grfx.RotateTransform( Rotation );
			grfx.DrawRectangle( new Pen( BorderColor, BorderThickness ), System.Drawing.Rectangle.Round( BorderBoundingBox ) );
			grfx.FillRectangle( new SolidBrush( FillColor ), ObjectBoundingBox );
			grfx.RotateTransform( -Rotation );
		}
	}
}
