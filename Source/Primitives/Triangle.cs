using Newtonsoft.Json;
using System.Drawing;

namespace Draw.Primitives
{
	using Components;
	using System.Collections.Generic;

	public class Triangle : ShapeBase
	{
		[JsonConstructor] private Triangle() { }
		public Triangle(ShapeBase shape, string name) : base(shape, name, typeof(Triangle).Name) { }
		public Triangle(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(Triangle).Name) { }

		// get 0 in a constant
		// This are point locations normalized
		protected override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(0, 0.5f),
			new PointF(-0.5f, -0.5f),
			new PointF(0.5f, -0.5f)
		};

		public override void DrawSelf(Graphics grfx)
		{
			PointF[] drawPoints = GetNormalizedPoints( ).ToArray( );
			GetShapeTransformationMatrix( ).TransformPoints(drawPoints);

			if (BorderThickness > 0)
			{
				PointF[] borderPoints = GetNormalizedPoints().ToArray();
				GetBorderTransformationMatrix( ).TransformPoints(borderPoints);
				grfx.DrawPolygon(new Pen(BorderColor, BorderThickness), borderPoints);
			}
			grfx.FillPolygon(new SolidBrush(FillColor), drawPoints);

			base.DrawSelf(grfx);
		}
	}
}
