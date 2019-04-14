using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace Draw.Primitives
{
	using Components;

	public class Rectangle : ShapeBase
	{
		[JsonConstructor] private Rectangle() { }
		public Rectangle(ShapeBase shape, string name) : base(shape, name, typeof(Rectangle).Name) { }
		public Rectangle(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(Rectangle).Name) { }

		protected override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(-0.5f, 0.5f),
			new PointF(0.5f, 0.5f),
			new PointF(0.5f, -0.5f),
			new PointF(-0.5f, -0.5f)
		};

		public override void DrawSelf(Graphics grfx)
		{
			PointF[] drawPoints = GetNormalizedPoints( ).ToArray( );
			GetShapeTransformationMatrix( ).TransformPoints(drawPoints);

			grfx.DrawPolygon(new Pen(BorderColor, BorderThickness), drawPoints);
			grfx.FillPolygon(new SolidBrush(FillColor), drawPoints);

			base.DrawSelf(grfx);
		}
	}
}
