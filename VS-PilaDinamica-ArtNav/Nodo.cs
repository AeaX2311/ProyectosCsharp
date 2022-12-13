using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_PilaDinamica_ArtNav {
    class Nodo <T> {
		public Nodo(T objeto) {
			Siguiente = null;
			ObjetoConDatos = objeto;
		}

		private T _objetoConDatos;

		public T ObjetoConDatos {
			get { return _objetoConDatos; }
			set { _objetoConDatos = value; }
		}

		private Nodo<T> _siguiente;

		public Nodo<T> Siguiente {
			get { return _siguiente; }
			set { _siguiente = value; }
		}

		~Nodo() {
			ObjetoConDatos = default;
		}
	}
}
