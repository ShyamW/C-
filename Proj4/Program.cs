using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BindingTest
{
	static class Program
	{
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Plane());
		}
	}
}
