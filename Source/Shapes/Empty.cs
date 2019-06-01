using Newtonsoft.Json;
using System.Drawing;

namespace PaintNET.Shapes
{
	using Abstracts;

	internal class Empty : ShapeBase
	{
		[JsonConstructor] private Empty() { }
		public Empty(string name) : base(name, typeof(Empty).Name) { }

		public override void DrawSelf(Graphics grfx)
		{
			return;
		}
	}
}
