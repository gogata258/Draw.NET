using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Draw.Primitives
{
	public class Group : ShapeBase
	{
		[JsonConstructor] private Group( ) { }
		public List<ShapeBase> Shapes { get; set; }

		public Group( ShapeBase shape, string name) : base(name, typeof(Group).Name)
		{
			Shapes = shape is Group g ? g.Shapes : new List<ShapeBase>( );
			UpdateProperties( );
		}

		public Group( string name, List<ShapeBase> shapes ) : base( name, typeof( Group ).Name )
		{
			Shapes = shapes;
			UpdateProperties( );
		}

		private void UpdateProperties( )
		{
			if (Shapes.Any( ))
			{
				ObjectLocX = Shapes.OrderBy( s => s.ObjectLocX ).First( ).ObjectLocX;
				ObjectLocY = Shapes.OrderBy( s => s.ObjectLocY ).First( ).ObjectLocY;
				ObjectHeight = Shapes.Select( s => new { Value = s.ObjectLocY + s.ObjectHeight } ).OrderByDescending( s => s.Value ).First( ).Value - ObjectLocY;
				ObjectWidth = Shapes.Select( s => new { Value = s.ObjectLocX + s.ObjectWidth } ).OrderByDescending( s => s.Value ).First( ).Value - ObjectLocX;
			}
		}

		public override void DrawSelf( Graphics grfx )
		{
			grfx.RotateTransform( Rotation );
			Shapes.ForEach( s => s.DrawSelf( grfx ) );
			grfx.RotateTransform( -Rotation );
		}

		public override void Translate( PointF distance )
		{
			Shapes.ForEach( s => s.Translate( distance ) );
			UpdateProperties( );
		}

		public override ShapeBase Contains( PointF point )
		{
			ShapeBase hitTarget = Shapes.FirstOrDefault(s => s.Contains(point) != null);
			if (hitTarget is null)
				hitTarget = BorderBoundingBox.Contains( point ) ? this : null;
			return hitTarget;
		}
	}
}
