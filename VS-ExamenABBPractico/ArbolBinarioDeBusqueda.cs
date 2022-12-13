using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ExamenABBPractico {
    class ArbolBinarioDeBusqueda<T> where T: IComparable<T>, IEquatable<T> {
        public ArbolBinarioDeBusqueda() {
            Raiz = null;
        }

        private Nodo<T> _raiz;

        private Nodo<T> Raiz {
            get { return _raiz; }
            set { _raiz = value; }
        }

        public bool Vacio {
            get {
                return Raiz == null;
            }
        }

        public bool Insertar(T objeto) {
            Nodo<T> nodoAux = new Nodo<T>(objeto);
            if (Vacio) { Raiz = nodoAux; return true; }

            Nodo<T> nodoPrev = null, nodoActual = Raiz;

            while (nodoActual != null) {
                nodoPrev = nodoActual;

                if (objeto.Equals(nodoActual.ObjetoConDatos)) {
                    MessageBox.Show("Se genero un duplicado en el random.."); return false;
                }

                if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1) {
                    nodoActual = nodoActual.Izquierdo; 
                } else {
                    nodoActual = nodoActual.Derecho; 
                }
            }

            if (objeto.CompareTo(nodoPrev.ObjetoConDatos) == 1) 
                nodoPrev.Derecho = nodoAux;
            else
                nodoPrev.Izquierdo = nodoAux;
        
            return true;
        }

        public T Eliminar(T objeto) {
            if (Vacio) return default;

            Nodo<T> nodoAux = null, nodoPrevio = null;

            foreach(Nodo<T> nodo in RecorrerYDevolverNodo(Raiz)) {
                if (objeto.Equals(nodo.ObjetoConDatos)) {
                    nodoAux = nodo; break;
                }
                nodoPrevio = nodo;
            }

            if (nodoAux != null) {
                T objetoAux = nodoAux.ObjetoConDatos;

                if (nodoAux.Izquierdo == null) {
                    if (nodoAux.Derecho == null) { //No tiene ningun hijo
                        if (nodoPrevio == null) {
                            Vaciar();
                            return objetoAux;
                        }

                        if (nodoPrevio.Izquierdo != null && nodoPrevio.Izquierdo.ObjetoConDatos.Equals(nodoAux.ObjetoConDatos)) {
                            nodoPrevio.Izquierdo = null;
                            return objetoAux;
                        }       

                        nodoPrevio.Derecho = null;
                        return objetoAux;

                    } else { //Solo tiene hijo derecho
                        if (nodoPrevio == null) {
                            Raiz = nodoAux.Derecho;
                            return objetoAux;
                        }
                        if (nodoPrevio.Izquierdo != null && nodoPrevio.Izquierdo.ObjetoConDatos.Equals(nodoAux.ObjetoConDatos)) {
                            nodoPrevio.Izquierdo = nodoAux.Derecho;
                            return objetoAux;
                        }
                        
                        nodoPrevio.Derecho = nodoAux.Derecho;
             
                        return objetoAux;
                    }

                } else if (nodoAux.Derecho == null) { //Solo tiene hijo izquierdo
                    if (nodoPrevio == null) {
                        Raiz = nodoAux.Izquierdo;
                        return objetoAux;
                    }
                    if (nodoPrevio.Izquierdo != null && nodoPrevio.Izquierdo.ObjetoConDatos.Equals(nodoAux.ObjetoConDatos)) {
                        nodoPrevio.Izquierdo = nodoAux.Izquierdo;
                        return objetoAux;
                    }

                    nodoPrevio.Derecho = nodoAux.Izquierdo;
                    return objetoAux;

                } else { //Tiene ambos hijos

                    Nodo<T> nodoAux2 = nodoAux.Derecho, nodoPrevio2 = nodoAux, nodoPrevio3 = nodoPrevio; 
                    
                    while (nodoAux2 != null) {
                        nodoPrevio3 = nodoPrevio2;
                        nodoPrevio2 = nodoAux2;
                        nodoAux2 = nodoAux2.Izquierdo;
                    } //nodoPrevio2 contiene el nodo menor del subarbol derecho
     
                    nodoPrevio2.Izquierdo = nodoAux.Izquierdo;

                    if (!nodoPrevio3.ObjetoConDatos.Equals(nodoAux.ObjetoConDatos)) {                    
                        nodoPrevio3.Izquierdo = nodoPrevio2.Derecho;
                        nodoPrevio2.Derecho = nodoAux.Derecho;
                    } //El anterior al menor apunta al derecho del menor

                    if (nodoPrevio != null) { //No es la raiz (esta en medio)
                        if (nodoPrevio.Izquierdo != null && nodoPrevio.Izquierdo.ObjetoConDatos.Equals(nodoAux.ObjetoConDatos)) {
                            nodoPrevio.Izquierdo = nodoPrevio2;
                            return objetoAux;
                        }

                        nodoPrevio.Derecho = nodoPrevio2;

                    } else //Es la raiz
                        Raiz = nodoPrevio2;

                    return objetoAux;
                } 
            }
            
            return default;
        }
        
        public T Buscar(T objeto) {
            if (Vacio) return default;

            return Buscar(Raiz, objeto);
        }

        private T Buscar(Nodo<T> nodoActual, T objeto) {
            if (nodoActual == null) return default;
            
            if (objeto.Equals(nodoActual.ObjetoConDatos)) return nodoActual.ObjetoConDatos;

            if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1) {
                return Buscar(nodoActual.Izquierdo, objeto);
            }else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1) {
                return Buscar(nodoActual.Derecho, objeto);
            }
            return default;
        }

        public IEnumerable<T> RecorrerPreOrden() {
            return RecorrerPreOrden(Raiz);
        }
           
        private IEnumerable<T> RecorrerPreOrden(Nodo<T> nodoActual) {
            if (nodoActual != null) {
                yield return nodoActual.ObjetoConDatos;

                foreach (T nodo in RecorrerPreOrden(nodoActual.Izquierdo)) yield return nodo;

                foreach (T nodo in RecorrerPreOrden(nodoActual.Derecho)) yield return nodo;
            }
        }

        public IEnumerable<T> RecorrerInOrden() {
            return RecorrerInOrden(Raiz);
        }

        private IEnumerable<T> RecorrerInOrden(Nodo<T> nodoActual) {
            if (nodoActual != null) {
                foreach (T nodo in RecorrerInOrden(nodoActual.Izquierdo)) yield return nodo;
                
                yield return nodoActual.ObjetoConDatos;             

                foreach (T nodo in RecorrerInOrden(nodoActual.Derecho)) yield return nodo;
            }
        }
        public IEnumerable<T> RecorrerPostOrden() {
            return RecorrerPostOrden(Raiz);
        }

        private IEnumerable<T> RecorrerPostOrden(Nodo<T> nodoActual) {
            if (nodoActual != null) {
                foreach (T nodo in RecorrerPostOrden(nodoActual.Izquierdo)) yield return nodo;

                foreach (T nodo in RecorrerPostOrden(nodoActual.Derecho)) yield return nodo;

                yield return nodoActual.ObjetoConDatos;
            }
        }

        public void Vaciar() {
            Raiz = null;
        }

        ~ArbolBinarioDeBusqueda() {
            Vaciar();
        }

        public string GenerarCodigoDOT() {
            if (Vacio) return "";

            string strResultado = "digraph Figura{\nRaiz->\"" + Raiz.ObjetoConDatos.ToString() + "\";";
            ConcatenarNodos(Raiz, ref strResultado);
            strResultado += "\n}";

            return strResultado;
        }

        private void ConcatenarNodos(Nodo<T> nodoActual, ref string strResultado) {
            if (nodoActual != null) {
                if (nodoActual.Izquierdo != null) 
                    strResultado += "\n\"" + nodoActual.ObjetoConDatos.ToString() + "\"->\"" + nodoActual.Izquierdo.ObjetoConDatos.ToString() + "\";";

                if (nodoActual.Derecho != null)
                    strResultado += "\n\"" + nodoActual.ObjetoConDatos.ToString() + "\"->\"" + nodoActual.Derecho.ObjetoConDatos.ToString() + "\";";

                ConcatenarNodos(nodoActual.Izquierdo, ref strResultado);
                ConcatenarNodos(nodoActual.Derecho, ref strResultado);
            }
        }

        private IEnumerable<Nodo<T>> RecorrerYDevolverNodo(Nodo<T> nodoActual) {
            if (nodoActual != null) {
                yield return nodoActual;
                foreach (Nodo<T> nodo in RecorrerYDevolverNodo(nodoActual.Izquierdo)) yield return nodo;

                yield return nodoActual;

                foreach (Nodo<T> nodo in RecorrerYDevolverNodo(nodoActual.Derecho)) yield return nodo;
                yield return nodoActual;
            }
        }

        public IEnumerable<Nodo<T>> DevolverNodosMayores(Nodo<T> nodoAux) {
            Nodo<T> nodoActual = null;
            
            foreach (T obj in RecorrerInOrden(Raiz)) {
                Nodo<T> nodo = new Nodo<T>(obj);
                if (nodo.ObjetoConDatos.Equals(nodoAux.ObjetoConDatos)){
                    nodoActual = nodo;
                    break;
                }
            }

            if (nodoActual == null) yield break;

            foreach (T obj in RecorrerInOrden(Raiz)) {
                Nodo<T> nodo = new Nodo<T>(obj);
                if (nodoActual.ObjetoConDatos.CompareTo(nodo.ObjetoConDatos) == -1) {                    
                    yield return nodo;
                }
            }
        }
    }
}
