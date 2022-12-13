using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_PracticaPolimorfismo {
    abstract class Adorno {
		private string _strNombre;

		public string Nombre {
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private double _dblCostoProduccion;

		public double CostoProduccion {
			get { return _dblCostoProduccion; }
			set { _dblCostoProduccion = value; }
		}

		public abstract double CalcularPrecio();
	}
}
