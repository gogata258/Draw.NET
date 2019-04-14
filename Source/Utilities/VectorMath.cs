using System;
using System.Drawing;
using System.Windows;

namespace Draw.Utilities
{
	public static class VectorMath
	{
		/// <summary>
		/// Gets the vector from p1 to p2
		/// </summary>
		/// <param name="p1">start point</param>
		/// <param name="p2">end point</param>
		/// <returns></returns>
		public static Vector GetVector(PointF p1, PointF p2) => new Vector(p1.X - p2.X, p1.Y - p2.Y);

		/// <summary>
		/// Gets the angle between the two vectors
		/// </summary>
		/// <param name="vect1"></param>
		/// <param name="vect2"></param>
		/// <returns></returns>
		public static float GetAngle(Vector vect1, Vector vect2) => (float) Vector.AngleBetween(vect1, vect2);

		public static float GetRotationDirection(Vector vect1, Vector vect2)
		{
			double rawData = Vector.CrossProduct(vect1, vect2); ;
			return rawData < 0 ? -1 : 1;
		}

	}
}
