using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionParticionDeMemorias {
    class Trabajo {
        private Unidad tamanio;

        public Unidad Tamanio {
            get { return tamanio; }
            set { tamanio = value; }
        }

        private string id;

        public string Id {
            get { return id; }
            set { id = value; }
        }

        public Trabajo(Unidad tamanio, string id) {
            Tamanio = tamanio;
            Id = id;
        }

        public Trabajo optimizarTamanio() {
            return new Trabajo(tamanio.optimizarTipo(), id);
        }

        public override string ToString() {
            return id + " " + tamanio.ToString();
        }
    }
}
