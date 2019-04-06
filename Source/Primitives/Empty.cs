using System.Drawing;

namespace Draw.Primitives
{
	internal class Empty : ShapeBase
	{
		public Empty(string name) : base(name) { }

		public override void DrawSelf(Graphics grfx)
		{
			return;
		}
	}
}
