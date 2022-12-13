using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_TDC.Archivos {
    [Serializable]class VitroPiso {
		private string _strMarca;

		public string Marca {
			get { return _strMarca; }
			set { _strMarca = value; }
		}

		private double _dblPrecio;

		public double Precio {
			get { return _dblPrecio; }
			set { _dblPrecio = value; }
		}

		private string _strColor;

		public string Color {
			get { return _strColor; }
			set { _strColor = value; }
		}

		private double _dblLargo;

		public double Largo {
			get { return _dblLargo; }
			set { _dblLargo = value; }
		}

		private double _dblAncho;

		public double Ancho {
			get { return _dblAncho; }
			set { _dblAncho = value; }
		}

		private double _dblEspesor;

		public double Espesor {
			get { return _dblEspesor; }
			set { _dblEspesor = value; }
		}

		private bool _blnVentaPorMayoreo;

		public bool VentaPorMayoreo {
			get { return _blnVentaPorMayoreo; }
			set { _blnVentaPorMayoreo = value; }
		}

		private char _chrCalidad;

		public char Calidad {
			get { return _chrCalidad; }
			set { _chrCalidad = value; }
		}

		private int _intCantidadPiezasPorPaquete;

		public int CantidadPiezasPorPaquete {
			get { return _intCantidadPiezasPorPaquete; }
			set { _intCantidadPiezasPorPaquete = value; }
		}

		private DateTime _dtmFechaRegistro;

		public DateTime FechaRegistro {
			get { return _dtmFechaRegistro; }
			set { _dtmFechaRegistro = value; }
		}
	}
}
