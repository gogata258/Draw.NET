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
		/// Gets the angle between the two vectors
		/// </summary>
		/// <param name="vect1"></param>
		/// <param name="vect2"></param>
		/// <returns></returns>
		public static float GetAngle(Vector2 vect1, Vector2 vect2) => (float) Math.Acos(Vector2.Dot(vect1, vect2) / (vect1.Length( ) * vect2.Length( )));

	}
}
