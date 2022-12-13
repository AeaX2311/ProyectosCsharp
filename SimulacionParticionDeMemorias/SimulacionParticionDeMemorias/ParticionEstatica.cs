using System;

namespace SimulacionParticionDeMemorias {
    class ParticionEstatica {
        private int id;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        private Unidad tamanio;

        public Unidad Tamanio {
            get {
                return tamanio; 
            }
            set { tamanio = value; }
        }

        private bool disponible;

        public bool IsDisponible {
            get { return disponible; }
            set { disponible = value; }
        }

        private Trabajo trabajo;

        public Trabajo Trabajo {
            get { return trabajo; }
        }

        public ParticionEstatica(int id, Unidad unidad) {
            Id = id;
            Tamanio = unidad;
            disponible = true;
        }

        public ParticionEstatica() { }

        public override string ToString() {
            return "Partición " + Id + " | " + Tamanio.ToString();
        }

        public void agregarTrabajo(Trabajo trabajo) {
            if(!IsDisponible)
                throw new Exception("Particion ya tiene trabajo asignado.");

            IsDisponible = false;
            this.trabajo = trabajo.optimizarTamanio();
        }

        public void quitarTrabajo() {
            if(IsDisponible)
                throw new Exception("Particion no tiene trabajo asignado.");

            IsDisponible = true;
            trabajo = null;
        }
    }
}
