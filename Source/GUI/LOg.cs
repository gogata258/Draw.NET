using System.Windows.Forms;

namespace Draw.GUI
{
	public partial class Log : Form
	{
		public Log() => InitializeComponent();

		public void WriteToLog(string text) => logTextBox.Text += $"\n{text}";
	}
}
