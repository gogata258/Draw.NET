using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintNET.Shapes.Abstracts
{
	public class ClosedCurveBase : ShapeBase
	{
		[JsonConstructor] protected ClosedCurveBase() { }
		public ClosedCurveBase(ShapeBase shape, string name, string type) : base(shape, name, type) { }
		public ClosedCurveBase(float X, float Y, float width, float height, string name, string type) : base(X, Y, width, height, name, type) { }

		public override void DrawSelf(Graphics grfx)
		{
			PointF[] drawPoints = GetNormalizedPoints( ).ToArray( );
			GetTransformationMatrix( ).TransformPoints(drawPoints);

			if (BorderAlpha > 0 && BorderThickness > 0)
				grfx.DrawClosedCurve(new Pen(BorderColor, BorderThickness), drawPoints, .8f, FillMode.Alternate);

			if (FillAlpha > 0)
				grfx.FillClosedCurve(new SolidBrush(FillColor), drawPoints, FillMode.Alternate, .8f);

			base.DrawSelf(grfx);
		}
	}
}
