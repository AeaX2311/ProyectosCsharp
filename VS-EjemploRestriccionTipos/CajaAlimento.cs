using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_EjemploRestriccionTipos {
    class CajaAlimento<Alimento> where Alimento:new() {
        public CajaAlimento() {
            unAlimento = new Alimento();
        }
        public CajaAlimento(Alimento primerAlimento) {
            unAlimento = primerAlimento;
        }

        private Alimento unAlimento;

        public Alimento ConsultarAlimento() {
            return unAlimento;
        }
        public void InsertarAlimento(Alimento nuevoAlimento) {
            if (nuevoAlimento != null) 
                unAlimento = nuevoAlimento;
        }

        ~CajaAlimento() {
            unAlimento = default;
        }
    }
}
