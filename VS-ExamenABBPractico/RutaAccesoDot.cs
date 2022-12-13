using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_ExamenABBPractico {
    static class RutasDeAcceso {
		private static string _strBat;

		public static string Bat {
			get { return _strBat; }
			set { _strBat = value; }
		}

		private static string _strFiguraSinExtension;

		public static string FiguraSinExtension {
			get { return _strFiguraSinExtension; }
			set { _strFiguraSinExtension = value; }
		}

		private static string _strFiguraJpg;

		public static string FiguraJpg {
			get { return _strFiguraJpg; }
			set { _strFiguraJpg = value; }
		}
	}
}
