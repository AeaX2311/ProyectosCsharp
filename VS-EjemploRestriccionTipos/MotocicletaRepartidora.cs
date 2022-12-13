using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_EjemploRestriccionTipos {
    class MotocicletaRepartidora<Alimento> where Alimento: IComparable<Alimento>, new() {
        public MotocicletaRepartidora() {
            ListaCajas = new List<CajaAlimento<Alimento>>();
        }
        private List<CajaAlimento<Alimento>> ListaCajas;

        public void InsertarCaja(CajaAlimento<Alimento> nuevaCaja) {
            if (nuevaCaja != null)
                ListaCajas.Add(nuevaCaja);
        }

        public void OrdenarCajas() {

            CajaAlimento<Alimento> aux;
            for(int x = 0; x < ListaCajas.Count-1; x++) {
                for(int y = ListaCajas.Count-1; y > x; y--) {
                    if (ListaCajas[y].ConsultarAlimento().CompareTo(ListaCajas[x].ConsultarAlimento())==-1) {
                        aux = ListaCajas[y];
                        ListaCajas[y] = ListaCajas[x];
                        ListaCajas[x] = aux;
                    }
                }
            }
           
            //NO SIRVE
            //ListaCajas.Sort();         
        }

        public IEnumerator<CajaAlimento<Alimento>> GetEnumerator() {
            return ListaCajas.GetEnumerator();
        }
        ~MotocicletaRepartidora() {
            ListaCajas.Clear();
        }
    }
}
