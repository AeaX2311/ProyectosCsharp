using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_3._3._1 {
    class Automovil {
        private Llanta[] llantas = new Llanta[4]; private int auxLlanta=0;
        private List<Puerta> puertas = new List<Puerta>();

        public bool InsertarLlanta(Llanta nuevaLlanta) {
            if (auxLlanta < 4) {
                llantas[auxLlanta] = nuevaLlanta;
                auxLlanta++;
                return true;
            }
            return false;
        }

        public void InsertarPuerta(Puerta nuevaPuerta) {
            puertas.Add(nuevaPuerta);
        }

        public IEnumerable<Llanta> LlantaS {
            get {
                foreach (Llanta l in llantas)
                    yield return l;
                yield break;
            }
        }

        public IEnumerator<Puerta> GetEnumerator() {
            return puertas.GetEnumerator();
        }
    }
}
