using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintNET.Shapes.Abstracts
{
	public abstract class PrimitiveBase : ShapeBase
	{
		[JsonConstructor] protected PrimitiveBase() { }
		public PrimitiveBase(ShapeBase shape, string name, string type) : base(shape, name, type) { }
		public PrimitiveBase(float X, float Y, float width, float height, string name, string type) : base(X, Y, width, height, name, type) { }

		public override void DrawSelf(Graphics grfx) => DrawSelf(grfx, GetTransformationMatrix( ));

		public override void DrawSelf(Graphics grfx, Matrix transformationMatrix)
		{
			PointF[] drawPoints = GetNormalizedPoints( ).ToArray( );
			transformationMatrix.TransformPoints(drawPoints);

			grfx.DrawPolygon(new Pen(BorderColor, BorderThickness), drawPoints);
			grfx.FillPolygon(new SolidBrush(FillColor), drawPoints);

			base.DrawSelf(grfx);
		}
	}
}
