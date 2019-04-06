using System.Windows.Forms;

namespace Draw.GUI.Components
{
	public class CustomBinding : Binding
	{
		private const string ERROR_STRING = "Error!";
		public CustomBinding(string destinationPropName, object source, string sourcePropName) : base(destinationPropName, source, sourcePropName)
		{
			ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;
			DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
			DataSourceNullValue = ERROR_STRING;
			NullValue = ERROR_STRING;
		}
	}
}
