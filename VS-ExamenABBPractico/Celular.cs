using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_ExamenABBPractico {
    class Celular : IEquatable<Celular>, IComparable<Celular> {
		private int _intClaveUnica;

		public int ClaveUnica {
			get { return _intClaveUnica; }
			set { _intClaveUnica = value; }
		}

		private string _strModelo;

		public string Modelo {
			get { return _strModelo; }
			set { _strModelo = value; }
		}

		private double _dblCosto;

		public double Costo {
			get { return _dblCosto; }
			set { _dblCosto = value; }
		}

		public bool Equals(Celular otroCelular) {
			return ClaveUnica == otroCelular.ClaveUnica;
		}

		public int CompareTo(Celular otroCelular) {
			if (ClaveUnica < otroCelular.ClaveUnica) return -1;
			if (ClaveUnica > otroCelular.ClaveUnica) return 1;
			return 0;
		}

		public override string ToString() {
			return ClaveUnica.ToString();
		}
	}
}
