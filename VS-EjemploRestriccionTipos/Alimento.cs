using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_EjemploRestriccionTipos {
    class Alimento : IComparable<Alimento>{

		private string  _strNombre;

		public string  Nombre {
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private double _dblPrecio;

		public double Precio {
			get { return _dblPrecio; }
			set { _dblPrecio = value; }
		}

		private string _strDireccion;

		public string Direccion {
			get { return _strDireccion; }
			set { _strDireccion = value; }
		}

		private double _dblDistancia;

		public double Distancia {
			get { return _dblDistancia; }
			set { _dblDistancia = value; }
		}

		public int CompareTo(Alimento otroAlimento) {
			if (otroAlimento.Distancia > Distancia)
				return -1;
			else if (otroAlimento.Distancia < Distancia)
				return 1;

			return 0;
		}
	}
}
