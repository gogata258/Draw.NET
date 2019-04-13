using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw.Primitives.Components
{
	public abstract partial class ShapeBase
	{
		[JsonIgnore] private const int BORDER_OBJEC_OVERLAP_DISTANCE = 1;
		private float medianPointX;
		private float medianPointY;
		[Obsolete("Use Scale instead")]private float width;
		[Obsolete("Use Scale instead")]private float height;
		private float borderThicknes;
		[Obsolete("Will be gone in next release. Implement color picker from within UI")] private int borderColor_R;
		[Obsolete("Will be gone in next release. Implement color picker from within UI")] private int borderColor_G;
		[Obsolete("Will be gone in next release. Implement color picker from within UI")] private int borderColor_B;
		[Obsolete("Will be gone in next release. Implement color picker from within UI")] private int borderColor_A;
		[Obsolete("Will be gone in next release. Implement color picker from within UI")] private int fillColor_R;
		[Obsolete("Will be gone in next release. Implement color picker from within UI")] private int fillColor_G;
		private int fillColor_B;
		private int fillColor_A;
		private string name;
		private float scaleX;
		private float scaleY;

		/// <summary>
		/// Calculated property. The width of the bounding box of the  border
		/// </summary>
		[Obsolete("Start using points and scale to determine actual screen size")]
		[JsonIgnore] internal float BorderWidth => Width + BorderThickness - (2 * BORDER_OBJEC_OVERLAP_DISTANCE);

		/// <summary>
		/// Calculated property. The height of the bounding box of the  border
		/// </summary>
		[Obsolete("Start using points and scale to determine actual screen size")]
		[JsonIgnore] internal float BorderHeigt => Height + BorderThickness - (2 * BORDER_OBJEC_OVERLAP_DISTANCE);
		protected virtual List<PointF> GetNormalizedPoints() => new List<PointF>( );
		public Color BorderColor { get; set; }
		public Color FillColor { get; set; }


		/// <summary>
		///  Calculated property. Describes the region of space to be filled with the object color. 
		///  Implemented like this to make the origin of the object {0, 0} to be at the relative center
		///  if the median point ranges from 0 to 1
		/// </summary>
		[Obsolete("Start using points and scale to determine actual screen size")]
		[JsonIgnore] public RectangleF ObjectBoundingBox => new RectangleF(-Width * RelativeMedianX, -Height * RelativeMedianY, Width, Height);

		/// <summary>
		///  Calculated property. Describes the region of space to be filled with the border color. 
		///  Implemented like this to make the origin of the object {0, 0} to be at the relative center
		///  if the median point ranges from 0 to 1 normalized
		/// </summary>
		[Obsolete("Start using points and scale to determine actual screen size")]
		[JsonIgnore] public RectangleF BorderBoundingBox => new RectangleF(-BorderWidth * RelativeMedianX, -BorderHeigt * RelativeMedianY, BorderWidth - (BorderWidth * RelativeMedianX), BorderHeigt - (BorderHeigt * RelativeMedianY));

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
		[Obsolete("Use Scale instead")] public float Width { get => width; set => width = (value < 0) ? 0 : value; }
		[Obsolete("Use Scale instead")] public float Height { get => height; set => height = (value < 0) ? 0 : value; }
		public float Rotation { get; set; }
		public float LocationX { get; set; }
		public float LocationY { get; set; }
		public float ScaleX { get => scaleX; set => scaleX = (value < 0) ? 0 : value; }
		public float ScaleY { get => scaleY; set => scaleY = (value < 0) ? 0 : value; }
		public float RelativeMedianX { get => medianPointX; set => medianPointX = (value < -1) ? -1 : (value > 1) ? 1 : value; }
		public float RelativeMedianY { get => medianPointY; set => medianPointY = (value < -1) ? -1 : (value > 1) ? 1 : value; }
		public float BorderThickness { get => borderThicknes; set => borderThicknes = value < 0 ? 0 : value; }
	}
}
