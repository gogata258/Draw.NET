using System;
using System.Windows.Forms;

namespace PaintNET
{
	public partial class DoubleBufferedPanel : UserControl
	{
		public DoubleBufferedPanel() => InitializeComponent( );

		public void Invalidate(Action updateUIControls)
		{
			Invalidate( );
			updateUIControls.Invoke( );
		}
	}
}
