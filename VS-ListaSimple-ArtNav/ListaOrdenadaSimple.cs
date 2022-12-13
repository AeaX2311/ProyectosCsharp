using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ListaOrdenada_ArtNav {
    class ListaOrdenadaSimple <T> where T : IEquatable<T> , IComparable<T>{
		private bool _blnOrdenada;

		public bool Ordenada {
			get { return _blnOrdenada; }
			set { _blnOrdenada = value; }
		}

		private bool _blnDuplicada;

		public bool Duplicada {
			get { return _blnDuplicada; }
			set { _blnDuplicada = value; }
		}

		public ListaOrdenadaSimple(bool blnOrdenada, bool blnDuplicada) {
			_blnOrdenada = blnOrdenada;
			_blnDuplicada = blnDuplicada;
			NodoInicial = null;
		}

		private Nodo<T> _nodoInicial;

		private Nodo<T> NodoInicial {
			get { return _nodoInicial; }
			set { _nodoInicial = value; }
		}

		public bool Vacia {
			get { return NodoInicial == null; }
		}

		public bool Agregar(T objeto) {
			Nodo<T> nodoNuevo = new Nodo<T>(); nodoNuevo.ObjetoConDatos = objeto;
			
			if (Vacia) {
				nodoNuevo.Siguiente = null;
				NodoInicial = nodoNuevo;
				return true;
			}

			Nodo<T> nodoActual =  NodoInicial;
			Nodo<T> nodoPrevio = new Nodo<T>();

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos) && !Duplicada) {
					MessageBox.Show("Ya existe una fabrica con ese nombre");
					return false;
				}

				if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1 && Ordenada) {
					if (nodoActual.Equals(NodoInicial)) {
						nodoNuevo.Siguiente = NodoInicial;
						NodoInicial = nodoNuevo;
						return true;
					}

					nodoNuevo.Siguiente = nodoPrevio.Siguiente;
					nodoPrevio.Siguiente = nodoNuevo;
					return true;
				}
	
				nodoPrevio = nodoActual;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			nodoPrevio.Siguiente = nodoNuevo;
			nodoNuevo.Siguiente = null;

			return true;
		}

		public IEnumerator<T> GetEnumerator() {
			if (Vacia) yield break;

			Nodo<T> nodoActual = NodoInicial;

			do {
				yield return nodoActual.ObjetoConDatos;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			yield break;
		}

		public T EliminarNodo(T objeto) {
			if (Vacia) throw new Exception("La lista esta vacia");

			Nodo<T> nodoActual = NodoInicial;
			Nodo<T> nodoPrevio = new Nodo<T>();
			T objAux;

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) { //Eliminar el nodoActual y regresarlo
					objAux = nodoActual.ObjetoConDatos;
					if (NodoInicial.ObjetoConDatos.Equals(nodoActual.ObjetoConDatos)) { //Principio
						NodoInicial = nodoActual.Siguiente;
						return objAux;
					}
					if (nodoActual.Siguiente == null) { //Final
						nodoPrevio.Siguiente = nodoActual.Siguiente;
						return objAux;
					} //Medio

					nodoPrevio.Siguiente = nodoActual.Siguiente;
					return objAux;
				}
				if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1 && Ordenada) break;

				nodoPrevio = nodoActual;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			throw new Exception("No existe dicho objeto");
		}

		public void Vaciar() {
			/*
			if (Vacia) return;
			Nodo<T> nodoActual = NodoInicial, nodoPrevio;

			do {
				nodoPrevio = nodoActual;
				nodoActual = nodoActual.Siguiente;
				nodoPrevio = null;
			} while (nodoActual != null);
			*/

			NodoInicial = null;
		}

		public T Buscar(T objeto) {
			if (!Vacia) {
				Nodo<T> nodoAux1 = NodoInicial;

				do {
					if (objeto.Equals(nodoAux1.ObjetoConDatos))
						return nodoAux1.ObjetoConDatos;

					if (objeto.CompareTo(nodoAux1.ObjetoConDatos) == -1 && Ordenada) break;

					nodoAux1 = nodoAux1.Siguiente;
				} while (nodoAux1 != null);
			}
			return default;
		}

		~ListaOrdenadaSimple() {
			Vaciar();
		}
	}
}
