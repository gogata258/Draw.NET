using System.Drawing;
using System.Windows;

namespace PaintNET.Utilities
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

		public static bool GetIntersectionWithLine(PointF p1, PointF p2, PointF q1, PointF q2) =>
			Orientation(p1, q1, p2) != Orientation(p1, q1, q2) && Orientation(p2, q2, p1) != Orientation(p2, q2, q1);

		private static float Orientation(PointF p, PointF q, PointF r)
		{
			float val = ((q.Y - p.Y) * (r.X - q.X)) - ((q.X - p.X) * (r.Y - q.Y));
			return val == 0
				? 0
				: (val > 0)
					? 1
					: 2;
		}
	}
}
