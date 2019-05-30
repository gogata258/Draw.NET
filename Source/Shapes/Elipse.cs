using Newtonsoft.Json;
using System.Drawing;

namespace Draw.Shapes
{
	using Abstracts;
	using System.Collections.Generic;

	public class Elipse : ClosedCurveBase
	{
		[JsonConstructor] private Elipse() { }
		public Elipse(ShapeBase shape, string name) : base(shape, name, typeof(Elipse).Name) { }
		public Elipse(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(Elipse).Name) { }

		public override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(-0.5f, 0.5f),
			new PointF(0.5f, 0.5f),
			new PointF(0.5f, -0.5f),
			new PointF(-0.5f, -0.5f)
		};
	}
}
