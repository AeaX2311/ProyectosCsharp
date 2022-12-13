namespace SimulacionParticionDeMemorias {
    class TrabajoDinamico {
        public TrabajoDinamico(Unidad tamanio, string id) {
            TamanioOcupado = tamanio;
            tamanioTotal = tamanio;
            Id = id;
        }

        private string id;

        public string Id {
            get { return id; }
            set { id = value; }
        }

        private Unidad tamanioOcupado;

        public Unidad TamanioOcupado {
            get { return tamanioOcupado; }
            set { tamanioOcupado = value; }
        }

        private Unidad tamanioTotal;

        public Unidad TamanioTotal {
            get { return tamanioTotal; }
            set { tamanioTotal = value; }
        }


        public bool isDisponible() {
            return tamanioOcupado == null || tamanioOcupado.Cantidad.Equals(0);
        }
  

      //  public Trabajo optimizarTamanio() {
         //   return new Trabajo(tamanioOcupado.optimizarTipo(), id);
        //}

        public override string ToString() {
            return "Ocupado: " + tamanioOcupado.ToString() + ". De: " + tamanioTotal.ToString();
        }
    }
}
