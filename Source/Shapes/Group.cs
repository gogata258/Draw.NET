using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Draw.Shapes
{
	using Abstracts;
	using System;

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
				LocationX = Shapes.Average(s => s.LocationX);
				LocationY = Shapes.Average(s => s.LocationY);

				float startX = Shapes.OrderBy(s => s.BoundingBox.X).First().BoundingBox.X;
				float endX = Shapes.OrderByDescending(s => s.BoundingBox.Right).First().BoundingBox.Right;

				float startY = Shapes.OrderBy(s => s.BoundingBox.Y).First().BoundingBox.Y;
				float endY = Shapes.OrderByDescending(s => s.BoundingBox.Bottom).First().BoundingBox.Bottom;

				ScaleX = Length(startX, endX);
				ScaleY = Length(startY, endY);
			}
		}

		/// <summary>
		/// Gets the distance between two points
		/// </summary>
		/// <param name="point1"></param>
		/// <param name="point2"></param>
		/// <returns></returns>
		public static float Length(float point1, float point2) => Math.Abs(point1) + Math.Abs(point2);

		protected override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(-0.5f, 0.5f),
			new PointF(0.5f, 0.5f),
			new PointF(0.5f, -0.5f),
			new PointF(-0.5f, -0.5f)
		};

		public override void DrawSelf(Graphics grfx)
		{
			PointF[] points = GetNormalizedPoints( ).ToArray( );
			GetTransformationMatrix( ).TransformPoints(points);

			if (BorderAlpha > 0)
				grfx.DrawPolygon(new Pen(BorderColor, BorderThickness), points);

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
				hitTarget = BoundingBox.Contains(point) ? this : null;
			return hitTarget;
		}
	}
}
