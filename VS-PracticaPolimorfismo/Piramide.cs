using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_PracticaPolimorfismo {
    class Piramide : Adorno, IEquatable<Piramide> {
        public override double CalcularPrecio() {
            return CostoProduccion + (CostoProduccion * 0.04);
        }

        public bool Equals(Piramide otraPiramide) {
            return this.CalcularPrecio()==otraPiramide.CalcularPrecio();
        }

        public override string ToString() {
            return "Piramide: " + Nombre + " | Costo de produccion: " + CostoProduccion;
        }
    }
}
