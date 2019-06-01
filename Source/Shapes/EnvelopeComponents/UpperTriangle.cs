using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace PaintNET.Shapes.EnvelopeComponents
{
	using Shapes.Abstracts;

	public class UpperTriangle : PrimitiveBase
	{
		[JsonConstructor] private UpperTriangle() { }
		public UpperTriangle(ShapeBase shape, string name) : base(shape, name, typeof(UpperTriangle).Name) { }
		public UpperTriangle(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(UpperTriangle).Name) { }

		public override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(0f, 0f),
			new PointF(1f, -0.5f),
			new PointF(-1f, -0.5f),
		};
	}
}
