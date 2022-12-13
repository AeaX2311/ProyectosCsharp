using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_5._3_Ejemplos {
    class Cliente : Persona{
        public bool EsMayorEdad() {
            int intEdad = base.CalcularEdad();
            return intEdad >= 18;
        }
    }
}
