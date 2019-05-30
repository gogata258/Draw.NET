using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace Draw.Shapes.EnvelopeComponents
{
	using Shapes.Abstracts;

	public class LeftBody : PrimitiveBase
	{
		[JsonConstructor] private LeftBody() { }
		public LeftBody(ShapeBase shape, string name) : base(shape, name, typeof(LeftBody).Name) { }
		public LeftBody(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(LeftBody).Name) { }

		public override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(0f, 0f),
			new PointF(-1f, -0.5f),
			new PointF(-1f, 0.5f),
			new PointF(0f, 0.5f)
		};
	}
}
