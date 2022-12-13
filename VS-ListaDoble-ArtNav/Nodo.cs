using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_ListaDoble_ArtNav {
    class Nodo <T> {
		public Nodo() {
			Siguiente = null;
		}

		public Nodo(T objeto) {
			_objetoConDatos = objeto;
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

		private Nodo<T> _anterior;

		public Nodo<T> Anterior {
			get { return _anterior; }
			set { _anterior = value; }
		}

		~Nodo() {
			ObjetoConDatos = default;
		}
	}
}
