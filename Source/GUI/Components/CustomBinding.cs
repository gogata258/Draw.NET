﻿using System.Runtime.InteropServices;
using System.Windows.Forms;

[assembly: ComVisible(false)]

namespace PaintNET.GUI.Components
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
