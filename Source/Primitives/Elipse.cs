using Newtonsoft.Json;
using System.Drawing;

namespace Draw.Primitives
{
	public class Elipse : ShapeBase
	{
		[JsonConstructor] private Elipse( ) { }
		public Elipse( ShapeBase shape, string name ) : base( shape, name, typeof(Elipse).Name) { }
		public Elipse( float X, float Y, float width, float height, string name ) : base( X, Y, width, height, name, typeof( Elipse ).Name ) { }

		public override void DrawSelf( Graphics grfx )
		{
			grfx.RotateTransform( Rotation );
			grfx.DrawEllipse( new Pen( new SolidBrush( BorderColor ) ), BorderBoundingBox );
			grfx.FillEllipse( new SolidBrush( FillColor ), ObjectBoundingBox );
			grfx.RotateTransform( -Rotation );
		}
	}
}
