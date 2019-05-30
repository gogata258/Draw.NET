using System;
using System.Windows.Forms;

namespace Draw
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
