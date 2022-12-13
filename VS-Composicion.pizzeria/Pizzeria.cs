using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_Composicion.pizzeria {
    class Pizzeria{
        public Pizzeria(string strNombre, string strTelefono) {
            Nombre = strNombre;
            Telefono = strTelefono;
            listaOrdenes = new List<Orden>();
        }

        private string _strNombre;

        public string  Nombre {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strTelefono;

        public string Telefono {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }

        private List<Orden> listaOrdenes;

        public void NuevaOrden(Orden nuevaOrden) {
            if(nuevaOrden!=null)
                listaOrdenes.Add(nuevaOrden);
        }

        public int ContarOrdenes() {
            return listaOrdenes.Count;
        }

        public IEnumerator<Orden> GetEnumerator() {
            foreach (Orden o in listaOrdenes)
                yield return o;
        }

        public void EliminarOrden(Orden otraOrden) {
            listaOrdenes.Remove(otraOrden);
        }

        public void PagarOrden(Orden otraOrden) {
            foreach (Orden o in listaOrdenes) {
                if (o.Equals(otraOrden)) {
                    o.Pagada = true; return;
                }
            }
        }

        ~Pizzeria() {
            listaOrdenes.Clear();
        }
    }
}
