using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_ExamenABBPractico {
    class Nodo <T> {
		public Nodo(T objeto) {
			Izquierdo = null;
			Derecho = null;
			ObjetoConDatos = objeto;
		}

		private T _objetoConDatos;

		public T ObjetoConDatos {
			get { return _objetoConDatos; }
			set { _objetoConDatos = value; }
		}

		private Nodo<T> _izquierdo;

		public Nodo<T> Izquierdo {
			get { return _izquierdo; }
			set { _izquierdo = value; }
		}

		private Nodo<T> _derecho;

		public Nodo<T> Derecho {
			get { return _derecho; }
			set { _derecho = value; }
		}

		~Nodo() {
			ObjetoConDatos = default;
		}
	}
}
