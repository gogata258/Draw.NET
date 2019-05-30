using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw.Shapes
{
	using Abstracts;
	using EnvelopeComponents;

	public class Envelope : ShapeBase
	{
		private List<ShapeBase> components;
		[JsonConstructor] private Envelope() { }
		public Envelope(ShapeBase shape, string name) : base(shape, name, typeof(Envelope).Name) => InitShape( );

		public Envelope(float x, float y, float width, float height, string name) : base(x, y, width, height, name, typeof(Rectangle).Name) => InitShape( );

		private void InitShape()
		{
			components = new List<ShapeBase>( )
			{
				new UpperTriangle(this, "triangle"),
				new LeftBody(this, "leftBody"),
				new RightBody(this, "rightBody")
			};

			BorderThickness = 3;
			BorderColor = Color.SlateBlue;
		}

		public override void DrawSelf(Graphics grfx)
		{
			Matrix matrix = GetTransformationMatrix( );
			foreach (ShapeBase shape in components)
			{
				PointF[] drawPoints = shape.GetNormalizedPoints().ToArray();
				matrix.TransformPoints(drawPoints);

				grfx.FillPolygon(new SolidBrush(FillColor), drawPoints);
				grfx.DrawPolygon(new Pen(BorderColor, BorderThickness), drawPoints);
			}

			base.DrawSelf(grfx);
		}
	}
}
