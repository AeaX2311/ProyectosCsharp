using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_PilaDinamica_ArtNav {
	class PilaDinamica<T> where T : IEquatable<T>, IComparable<T> {
		public PilaDinamica() {
			Top = null;
		}

		private Nodo<T> _top;

		private Nodo<T> Top {
			get { return _top; }
			set { _top = value; }
		}

		public bool Vacia { get { return Top == null; } }

		public IEnumerator<T> GetEnumerator() {
			Nodo<T> nodoAux = Top;
			while (nodoAux != null) {
				yield return nodoAux.ObjetoConDatos;
				nodoAux = nodoAux.Siguiente;
			}
			yield break;
		}

		public T Buscar(T objeto) {
			if (Vacia) return default;

			Nodo<T> nodoActual = Top;

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) return nodoActual.ObjetoConDatos;

				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			return default;
		}

		public T Pop() {
			if (Vacia) return default;

			T objAux = Top.ObjetoConDatos;
			Top = Top.Siguiente;

			return objAux;
		}

		public T Pop(T objeto) {
			if (Vacia) return default;

			Nodo<T> nodoActual = Top, nodoPrevio = null; T objAux;

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) {
					if (nodoPrevio == null) return Pop();

					objAux = nodoActual.ObjetoConDatos;
					nodoPrevio.Siguiente = nodoActual.Siguiente;
					return objAux;
				}
				nodoPrevio = nodoActual;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			return default;
		}

		public bool Push(T objeto) {
			Nodo<T> nodoAux = new Nodo<T>(objeto);

			if (Vacia) { Top = nodoAux; return true; }

			Nodo<T> nodoActual = Top; do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) { MessageBox.Show("No se permiten nombres duplicados"); return false; }
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			nodoAux.Siguiente = Top;
			Top = nodoAux;

			return true;
		}

		public void Vaciar() {
			Top = null;
		}

		~PilaDinamica() {
			Vaciar();
		}
	}
}
