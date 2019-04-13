using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Draw.Primitives
{
	using Components;

	public class Group : ShapeBase
	{
		[JsonConstructor] private Group() { }
		public List<ShapeBase> Shapes { get; set; }

		public Group(ShapeBase shape, string name) : base(name, typeof(Group).Name)
		{
			Shapes = shape is Group g ? g.Shapes : new List<ShapeBase>( );
			UpdateProperties( );
		}

		public Group(string name, List<ShapeBase> shapes) : base(name, typeof(Group).Name)
		{
			Shapes = shapes;
			UpdateProperties( );
		}

		private void UpdateProperties()
		{
			if (Shapes.Any( ))
			{
				float widthStart = Shapes.OrderBy( s => s.BorderBoundingBox.Left).First( ).BorderBoundingBox.Left;
				float widthEnd = Shapes.OrderByDescending( s => s.BorderBoundingBox.Right).First( ).BorderBoundingBox.Right;
				Height = ShapeBase.Length(widthStart, widthEnd);

				float heightStart = Shapes.OrderBy( s => s.BorderBoundingBox.Top).First( ).BorderBoundingBox.Top;
				float heightEnd = Shapes.OrderByDescending( s => s.BorderBoundingBox.Bottom).First( ).BorderBoundingBox.Bottom;
				Width = ShapeBase.Length(heightStart, heightEnd);

				LocationX = Shapes.Average(s => s.LocationX);
				LocationY = Shapes.Average(s => s.LocationY);
			}
		}

		public override void DrawSelf(Graphics grfx)
		{
			grfx.RotateTransform(Rotation);
			Shapes.ForEach(s => s.DrawSelf(grfx));
			base.DrawSelf(grfx);
		}

		public override void Translate(PointF distance)
		{
			Shapes.ForEach(s => s.Translate(distance));
			UpdateProperties( );
		}

		public override ShapeBase Contains(PointF point)
		{
			ShapeBase hitTarget = Shapes.FirstOrDefault(s => s.Contains(point) != null);
			if (hitTarget is null)
				hitTarget = BorderBoundingBox.Contains(point) ? this : null;
			return hitTarget;
		}
	}
}
