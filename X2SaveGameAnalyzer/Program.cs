using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace X2SaveGameAnalyzer {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		public static string GetVersion() {
			var version = Assembly.GetExecutingAssembly().GetName().Version;
			return $"v{version.Major}.{version.Minor}.{version.Build}";
		}
	}
}
