﻿using System;
using System.Windows.Forms;

namespace PaintNET
{
	using GUI;

	internal sealed class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm( ));
		}

	}
}
