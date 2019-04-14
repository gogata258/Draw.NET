using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw.Shapes
{
	using System.Collections.Generic;
	using Abstracts;

	public class Elipse : ClosedCurveBase
	{
		[JsonConstructor] private Elipse() { }
		public Elipse(ShapeBase shape, string name) : base(shape, name, typeof(Elipse).Name) { }
		public Elipse(float X, float Y, float width, float height, string name) : base(X, Y, width, height, name, typeof(Elipse).Name) { }

		protected override List<PointF> GetNormalizedPoints() => new List<PointF>( )
		{
			new PointF(-0.5f, 0.5f),
			new PointF(0.5f, 0.5f),
			new PointF(0.5f, -0.5f),
			new PointF(-0.5f, -0.5f)
		};
	}
}
