using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Linq;

namespace Draw.Shapes.Abstracts
{
	public abstract partial class ShapeBase
	{
		private float medianPointX;
		private float medianPointY;
		private float borderThicknes;
		private string name;
		private float scaleX;
		private float scaleY;

		private Color borderColor;
		private int borderAlpha;

		private Color fillColor;
		private int fillAlpha;

		public Color BorderColor
		{
			get => borderColor;
			set => borderColor = Color.FromArgb(borderAlpha, value);
		}

		public Color FillColor
		{
			get => fillColor;
			set => fillColor = Color.FromArgb(fillAlpha, value);
		}

		/// <summary>
		///  Calculated property. Describes the region of space to be filled with the object color. 
		///  Implemented like this to make the origin of the object {0, 0} to be at the relative center
		///  if the median point ranges from 0 to 1
		/// </summary>
		[JsonIgnore]
		public RectangleF BoundingBox
		{
			get
			{
				PointF[] points = GetTransformedPoints( );
				float startPointX = points.ToList().OrderBy(p => p.X).First().X;
				float startPointY = points.ToList().OrderBy(p => p.Y).First().Y;
				return new RectangleF(startPointX, startPointY, scaleX, ScaleY);
			}
		}

		/// <summary>
		/// The origin of the point. Used to tell the rotater how to rotate the object
		/// Calculates from normalized value (0 to 1) to coordinates bound by the object dimentions
		/// </summary>
		[JsonIgnore] public PointF MedianPoint => new PointF(LocationX - (LocationX * RelativeMedianX), LocationY - (LocationY * RelativeMedianY));

		/// <summary>
		/// The property used to identify the shape
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// The name of the actual class that implements BaseShape
		/// Used by reflection for importing saved drawings
		/// </summary>
		public string ShapeType { get; set; }

		/// <summary>
		/// The name of the shape displayed in the UI
		/// </summary>
		public string Name { get => name; set => name = !string.IsNullOrWhiteSpace(value) ? value : Id.ToString( ); }
		public float Rotation { get; set; }
		public float LocationX { get; set; }
		public float LocationY { get; set; }
		public float ScaleX { get => scaleX; set => scaleX = (value < 0) ? 0 : value; }
		public float ScaleY { get => scaleY; set => scaleY = (value < 0) ? 0 : value; }
		public float RelativeMedianX { get => medianPointX; set => medianPointX = (value < -1) ? -1 : (value > 1) ? 1 : value; }
		public float RelativeMedianY { get => medianPointY; set => medianPointY = (value < -1) ? -1 : (value > 1) ? 1 : value; }
		public float BorderThickness { get => borderThicknes; set => borderThicknes = value < 0 ? 0 : value; }
		public int BorderAlpha
		{
			get => borderAlpha;
			set
			{
				borderAlpha = (value < 0) ? 0 : (value > 255) ? 255 : value;
				BorderColor = BorderColor;
			}
		}
		public int FillAlpha
		{
			get => fillAlpha;
			set
			{
				fillAlpha = (value < 0) ? 0 : (value > 255) ? 255 : value;
				FillColor = FillColor;
			}
		}
	}
}
