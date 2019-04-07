using Newtonsoft.Json;
using System;
using System.Drawing;

namespace Draw.Primitives
{
	public abstract class ShapeBase
	{
		[JsonIgnore] internal const int BORDER_OBJEC_OVERLAP_DISTANCE = 1;

		#region Constructors
		internal ShapeBase( ) { }
		internal ShapeBase( string name , string type)
		{
			Id = Guid.NewGuid( );
			Name = name;
			ShapeType = type;
		}
		public ShapeBase( float X, float Y, float width, float height, string name, string type) : this(name, type)
		{
			ObjectLocX = X;
			ObjectLocY = Y;
			ObjectWidth = width;
			ObjectHeight = height;

			SetFillColor( Color.IndianRed );
			SetBorderColor( Color.Indigo );
			BorderThickness = 0;
		}
		public ShapeBase( ShapeBase shape, string name, string type ) : this( shape.ObjectLocation.X, shape.ObjectLocation.Y, shape.ObjectWidth, shape.ObjectHeight, name, type )
		{
			BorderThickness = shape.BorderThickness;
			SetFillColor( shape.FillColor );
			SetBorderColor( shape.BorderColor );
		}
		#endregion

		private float width;
		private float height;
		private float borderThickness;
		private int borderColor_R;
		private int borderColor_G;
		private int borderColor_B;
		private int borderColor_A;
		private int fillColor_R;
		private int fillColor_G;
		private int fillColor_B;
		private int fillColor_A;
		private string name;

		private void SetBorderColor( Color color )
		{
			BorderColor_A = color.A;
			BorderColor_R = color.R;
			BorderColor_G = color.G;
			BorderColor_B = color.B;
		}

		private void SetFillColor( Color color )
		{
			FillColor_A = color.A;
			FillColor_R = color.R;
			FillColor_G = color.G;
			FillColor_B = color.B;
		}

		#region Properties

		[JsonIgnore] internal float BorderWidth => ObjectWidth + BorderThickness - ( 2 * BORDER_OBJEC_OVERLAP_DISTANCE );
		[JsonIgnore] internal float BorderHeigt => ObjectHeight + BorderThickness - ( 2 * BORDER_OBJEC_OVERLAP_DISTANCE );
		[JsonIgnore] internal float BorderLocX => ObjectLocX - ( BorderThickness / 2 ) + BORDER_OBJEC_OVERLAP_DISTANCE;
		[JsonIgnore] internal float BorderLocY => ObjectLocY - ( BorderThickness / 2 ) + BORDER_OBJEC_OVERLAP_DISTANCE;


		[JsonIgnore] public Color BorderColor => Color.FromArgb( BorderColor_A, BorderColor_R, BorderColor_G, BorderColor_B );
		[JsonIgnore] public Color FillColor => Color.FromArgb( FillColor_A, FillColor_R, FillColor_G, FillColor_B );
		[JsonIgnore] public RectangleF ObjectBoundingBox => new RectangleF( ObjectLocation, new SizeF( ObjectWidth, ObjectHeight ) );
		[JsonIgnore] public RectangleF BorderBoundingBox => new RectangleF( BorderLocation, new SizeF( BorderWidth, BorderHeigt ) );
		[JsonIgnore] public PointF ObjectLocation => new PointF( ObjectLocX, ObjectLocY );
		[JsonIgnore] public PointF BorderLocation => new PointF( BorderLocX, BorderLocY );

		public Guid Id { get; set; }
		public string ShapeType { get; set; }

		public string Name
		{
			get => name;
			set
			{
				if (!string.IsNullOrWhiteSpace( value ))
					name = value;
			}
		}


		#region Dimensions
		public float ObjectWidth
		{
			get => width;
			set => width = value >= 0 ? value : 0;
		}
		public float ObjectHeight
		{
			get => height;
			set => height = ( value >= 0 ) ? value : 0;
		}
		public float ObjectLocX { get; set; }
		public float ObjectLocY { get; set; }
		public float Rotation { get; set; }
		#endregion

		#region Fill
		public int FillColor_R
		{
			get => fillColor_R;
			set => fillColor_R = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		public int FillColor_G
		{
			get => fillColor_G;
			set => fillColor_G = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		public int FillColor_B
		{
			get => fillColor_B;
			set => fillColor_B = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		public int FillColor_A
		{
			get => fillColor_A;
			set => fillColor_A = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		#endregion

		#region Border
		public int BorderColor_R
		{
			get => borderColor_R;
			set => borderColor_R = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		public int BorderColor_G
		{
			get => borderColor_G;
			set => borderColor_G = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		public int BorderColor_B
		{
			get => borderColor_B;
			set => borderColor_B = value < 0 ? 0 : value > 255 ? 255 : value;
		}
		public int BorderColor_A
		{
			get => borderColor_A;
			set => borderColor_A = value < 0 ? 0 : value > 255 ? 255 : value;
		}

		public float BorderThickness
		{
			get => borderThickness < 0 ? 0 : borderThickness;
			set => borderThickness = value < 0 ? 0 : value;
		}
		#endregion

		#endregion
		public virtual void Translate( PointF distance )
		{
			ObjectLocX += distance.X;
			ObjectLocY += distance.Y;
		}

		public virtual ShapeBase Contains( PointF point ) => BorderBoundingBox.Contains( point.X, point.Y ) ? this : null;

		public abstract void DrawSelf( Graphics grfx );
	}
}
