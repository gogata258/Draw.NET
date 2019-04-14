using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;

namespace Draw.Shapes.Abstracts
{
	/// <summary>
	/// All shapes derrive from Base Shape
	/// </summary>
	public abstract partial class ShapeBase
	{
		private const float DEFAULT_MEDIAN_POINT_RELATIVE_LOCATION = 0.0f;
		private readonly Color defaultColor = Color.Orange;

		/// <summary>
		/// This ctor is used for JSon import
		/// </summary>
		internal ShapeBase() { }

		/// <summary>
		/// Used when the shape has no visual component. Like Group or Empty
		/// </summary>
		/// <param name="name">name of the shape</param>
		/// <param name="type">the name of the class of the instantiated shape</param>
		internal ShapeBase(string name, string type)
		{
			Id = Guid.NewGuid( );
			Name = name;
			ShapeType = type;
			RelativeMedianX = DEFAULT_MEDIAN_POINT_RELATIVE_LOCATION;
			RelativeMedianY = DEFAULT_MEDIAN_POINT_RELATIVE_LOCATION;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="X">The X component of the top left corner of the bonding box</param>
		/// <param name="Y">The Y component of the top left corner of the bonding box</param>
		/// <param name="scaleX">The width of the object</param>
		/// <param name="scaleY">The height of the object</param>
		/// <param name="name">name of the shape</param>
		/// <param name="type">the name of the class of the instantiated shape</param>
		public ShapeBase(float X, float Y, float scaleX, float scaleY, string name, string type) : this(name, type)
		{
			LocationX = X;
			LocationY = Y;
			ScaleX = scaleX;
			ScaleY = scaleY;

			FillColor = defaultColor;
			FillAlpha = 255;
			BorderColor = defaultColor;
			BorderAlpha = 255;
			BorderThickness = 0;
		}

		/// <summary>
		/// Used when duplicating objects
		/// </summary>
		/// <param name="shape">The model to for the duplication</param>
		/// <param name="name">name of the shape</param>
		/// <param name="type">the name of the class of the instantiated shape</param>
		public ShapeBase(ShapeBase shape, string name, string type) : this(shape.LocationX, shape.LocationY, shape.ScaleX, shape.ScaleY, name, type)
		{
			BorderThickness = shape.BorderThickness;
			FillColor = shape.FillColor;
			BorderColor = shape.BorderColor;
		}

		/// <summary>
		/// Translates the object
		/// </summary>
		/// <param name="distance"></param>
		public virtual void Translate(Vector vect)
		{
			LocationX -= (float)vect.X;
			LocationY -= (float)vect.Y;
		}

		/// <summary>
		/// Rotate the shape
		/// </summary>
		/// <param name="angle"></param>
		public virtual void Rotate(float angle) => Rotation += angle;

		/// <summary>
		/// Scale the shape
		/// </summary>
		/// <param name="size">the delta dimetions of scaling</param>
		public virtual void Scale(Vector size)
		{
			ScaleX += (float)size.X;
			ScaleY += (float)size.Y;
		}

		/// <summary>
		/// Checks if the  given point is within the object bounds
		/// </summary>
		/// <param name="point">point to check</param>
		/// <returns></returns>
		public virtual ShapeBase Contains(PointF point) => BoundingBox.Contains(point.X, point.Y) ? this : null;

		/// <summary>
		/// Virtual method for the drawiwng. Should always be overwritten
		/// </summary>
		/// <param name="grfx">The graphics which to use to draw the shape</param>
		public virtual void DrawSelf(Graphics grfx) => grfx.ResetTransform( );

		/// <summary>
		/// Get the transformation matrix from the current properties of the shape
		/// </summary>
		/// <returns>Matrix that applies all transformations</returns>
		protected virtual Matrix GetTransformationMatrix()
		{
			var matrix = new Matrix();
			matrix.RotateAt(Rotation, MedianPoint);
			matrix.Translate(LocationX, LocationY);
			matrix.Scale(ScaleX, ScaleY);
			return matrix;
		}

		/// <summary>
		/// List of points that describe the shape. Should be overriden by any drawable shape
		/// </summary>
		/// <returns>List of points that describe the shape</returns>
		protected virtual List<PointF> GetNormalizedPoints() => new List<PointF>( );

		/// <summary>
		/// Get the transformed points as there are before the shape is are draw on the screen
		/// </summary>s
		/// <returns></returns>
		protected PointF[] GetTransformedPoints()
		{
			PointF[] points = GetNormalizedPoints( ).ToArray( );
			GetTransformationMatrix( ).TransformPoints(points);
			return points;
		}
	}
}
