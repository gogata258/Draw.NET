using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace PaintNET.Shapes
{
	using Abstracts;

	public class Rectangle : PrimitiveBase
	{
		[JsonConstructor] private Rectangle() { }
		public Rectangle(ShapeBase shape, string name) : base(shape, name, typeof(Rectangle).Name) { }
		public Rectangle(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(Rectangle).Name) { }

		public override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(-0.5f, 0.5f),
			new PointF(0.5f, 0.5f),
			new PointF(0.5f, -0.5f),
			new PointF(-0.5f, -0.5f)
		};
	}
}