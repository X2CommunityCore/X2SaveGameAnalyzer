using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X2SaveDataLib {
	public class X2SaveModData {
		/// <summary>
		/// List of designators that is used to identify a mod as official DLC as indicated by the IsDlc property.
		/// </summary>
		public static List<string> DlcDesignatorList = new List<string> { "XCom_DLC_Day0", "DLC_1", "DLC_2", "DLC_3", "TLE" };

		public int Index { get; private set; }
		public string Designation1 { get; private set; }
		public string Designation2 { get; private set; }
		public bool IsDlc { get; private set; }

		public X2SaveModData(int index, string designation1, string designation2) {
			Index = index;
			Designation1 = designation1;
			Designation2 = designation2;
			IsDlc = DlcDesignatorList.Contains(designation1);
		}
	}
}
