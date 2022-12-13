using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ColaDinamica_ArtNav {
    class ColaDinamica<T> where T:IEquatable<T> {
		private Nodo<T> _final;

		private Nodo<T> Final {
			get { return _final; }
			set { _final = value; }
		}

		private Nodo<T> _frente;

		private Nodo<T> Frente {
			get { return _frente; }
			set { _frente = value; }
		}

		public bool Vacia {
			get { return Frente == null; }
		}

		public bool InsertarNodo(T objeto) {
			Nodo<T> nuevoNodo = new Nodo<T>(objeto);
			if (Vacia) {
				Frente = Final = nuevoNodo;
				return true;
			}

			Nodo<T> nodoActual = Frente;
			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) {
					MessageBox.Show("Elemento con nombre repetido.");
					return false;
				}

				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			Final.Siguiente = Final = nuevoNodo;
	
			return true;
		}

		public T EliminarNodo() {
			if (Vacia) return default;

			Nodo<T> nodoAux = Frente; T objAux = nodoAux.ObjetoConDatos;
			Frente = Frente.Siguiente; nodoAux = null;

			return objAux;
		}

		public T EliminarNodo(T objeto) {
			if (Vacia) return default;

			Nodo<T> nodoActual = Frente, nodoPrevio = null; T objAux;

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) {
					if (nodoPrevio == null) return EliminarNodo();

					objAux = nodoActual.ObjetoConDatos;

					if (nodoActual == Final) Final = nodoPrevio;

					nodoPrevio.Siguiente = nodoActual.Siguiente;

					return objAux;
				}
				nodoPrevio = nodoActual;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			return default;
		}

		public T BuscarNodo(T objeto) {
			if (Vacia) return default;

			Nodo<T> nodoActual = Frente;

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) return nodoActual.ObjetoConDatos;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			return default;
		}

		public void Vaciar() {
			if (Vacia) return;

			Frente = null;
			Final = null;
		}

		public IEnumerator<T> GetEnumerator() {
			Nodo<T> nodoActual = Frente;
			while (nodoActual != null) {
				yield return nodoActual.ObjetoConDatos;
				nodoActual = nodoActual.Siguiente;
			}
			yield break;
		}

		~ColaDinamica() {
			Vaciar();
		}
	}
}
