using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VS_ListaDoble_ArtNav {
	class ListaDoble<T> where T : IEquatable<T>, IComparable<T> {
		public ListaDoble() {
			NodoInicial = null;
			NodoFinal = null;
		}

		public IEnumerable<T> HaciaAdelante {
			get {
				if (Vacia) yield break;
				Nodo<T> nodoActual = NodoInicial;
				do {
					yield return nodoActual.ObjetoConDatos;
					nodoActual = nodoActual.Siguiente;
				} while (nodoActual != null);

				yield break;
			}
		}

		public IEnumerable<T> HaciaAtras {
			get {
				if (Vacia) yield break;
				Nodo<T> nodoActual = NodoFinal;
				do {
					yield return nodoActual.ObjetoConDatos;
					nodoActual = nodoActual.Anterior;
				} while (nodoActual != null);

				yield break;
			}
		}

		private Nodo<T> _nodoInicial;

		private Nodo<T> NodoInicial {
			get { return _nodoInicial; }
			set { _nodoInicial = value; }
		}

		private Nodo<T> _nodoFinal;

		private Nodo<T> NodoFinal {
			get { return _nodoFinal; }
			set { _nodoFinal = value; }
		}

		public bool Vacia {
			get {
				return NodoInicial == null || NodoFinal == null;
			}
		}

		public bool Agregar(T objeto) {
			Nodo<T> nodoAux = new Nodo<T>(objeto);

			if (Vacia) {
				NodoInicial = nodoAux;
				NodoFinal = nodoAux; return true;
			}

			Nodo<T> nodoActual = NodoInicial, nodoPrevio;

			do {
				if (objeto.Equals(nodoActual.ObjetoConDatos)) {
					MessageBox.Show("Ya existe un elemento con el mismo nombre");
					return false;
				}

				nodoPrevio = nodoActual;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);

			nodoPrevio.Siguiente = nodoAux;
			nodoAux.Anterior = nodoPrevio;
			NodoFinal = nodoAux;
			return true;
		}

		public T Buscar(T objeto) {
			if (!Vacia) {
				Nodo<T> nodoAux1 = NodoInicial, nodoAux2 = NodoFinal;

				bool p1 = false, p2 = true;
				do {
					if (objeto.Equals(nodoAux1.ObjetoConDatos))
						return nodoAux1.ObjetoConDatos;
					else if (objeto.Equals(nodoAux2.ObjetoConDatos))
						return nodoAux2.ObjetoConDatos;

					if (p1) p2 = false;

					nodoAux1 = nodoAux1.Siguiente;
					nodoAux2 = nodoAux2.Anterior;

					if (nodoAux1.Siguiente == nodoAux2 || nodoAux1 == nodoAux2) p1 = true;
				} while (p2);
			}
			return default;
		}

		public T EliminarNodo(T objeto) {
			if (Vacia) { MessageBox.Show("La lista esta vacia"); return default; }

			Nodo<T> nodoAux1 = NodoInicial, nodoAux2 = NodoFinal, miNodo = null;
			do {
				if (objeto.Equals(nodoAux1.ObjetoConDatos)) { miNodo = nodoAux1; break; }
				if (objeto.Equals(nodoAux2.ObjetoConDatos)) { miNodo = nodoAux2; break; }
				if (nodoAux1.Siguiente == nodoAux2 || nodoAux1 == nodoAux2) break;

				nodoAux1 = nodoAux1.Siguiente;
				nodoAux2 = nodoAux2.Anterior;
			} while (nodoAux1 != null && nodoAux2 != null);

			if (miNodo == null) return default;

			T objetoAux = miNodo.ObjetoConDatos;
			if (miNodo.Siguiente == null && miNodo.Anterior == null) { 
				Vaciar(); return objetoAux;
			}

			if (miNodo.Anterior == null) {
				NodoInicial = NodoInicial.Siguiente;
			} else if (miNodo.Siguiente == null) {
				NodoFinal.Anterior.Siguiente = null;
				NodoFinal = NodoFinal.Anterior;
			} else { 
				miNodo.Anterior.Siguiente = miNodo.Siguiente;
				miNodo.Siguiente.Anterior = miNodo.Anterior;
			}
			return objetoAux;
		}

		public void Vaciar() {
			if (!Vacia) {
				Nodo<T> nodoAux1 = NodoInicial, nodoAux2 = NodoFinal, nodop1, nodop2;
				
				while (nodoAux1.Siguiente != nodoAux2 && nodoAux1 != nodoAux2) {
					nodop1 = nodoAux1; nodop2 = nodoAux2; //Guardar previos
					nodoAux1 = nodoAux1.Siguiente; nodoAux2 = nodoAux2.Anterior; //Pasar siguiente elemento
					nodop1 = null; nodop2 = null; //Eliminar nodos previos
				}
				NodoFinal = null; NodoInicial = null;
			}
		}

		~ListaDoble() {
			Vaciar();
		}

	}
}
