using System;
using System.Drawing;
using System.Numerics;

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
		public static Vector2 GetVector(PointF p1, PointF p2) => new Vector2(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));

		/// <summary>
		/// Get the normalized vector (showing only direction)
		/// </summary>
		/// <param name="p1">start point</param>
		/// <param name="p2">end point</param>
		/// <returns></returns>
		public static Vector2 GetNormalizedVector(PointF p1, PointF p2) => Vector2.Normalize(GetVector(p1, p2));

		/// <summary>
		/// Gets the angle between the two vectors
		/// </summary>
		/// <param name="vect1"></param>
		/// <param name="vect2"></param>
		/// <returns></returns>
		public static float GetAngle(Vector2 vect1, Vector2 vect2) => (float) Math.Acos(Vector2.Dot(vect1, vect2) / (vect1.LengthSquared( ) * vect2.LengthSquared( )));

		public static float GetRotationDirection(Vector2 vect1, Vector2 vect2)
		{
			Vector2 cross = Vector2.Multiply(vect1,vect2);
			float rawData = Vector2.Multiply(vect1, vect2).X;
			return rawData < 0 ? -1 : 1;
		}

	}
}
