using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace PaintNET.Shapes.EnvelopeComponents
{
	using Shapes.Abstracts;

	public class RightBody : PrimitiveBase
	{
		[JsonConstructor] private RightBody() { }
		public RightBody(ShapeBase shape, string name) : base(shape, name, typeof(RightBody).Name) { }
		public RightBody(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(RightBody).Name) { }

		public override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(0f, 0f),
			new PointF(1f, -0.5f),
			new PointF(1f, 0.5f),
			new PointF(0f, 0.5f)
		};
	}
}
