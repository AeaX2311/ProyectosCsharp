using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_Ejemplo.Pizzeria {
    class Pizza {
        private int _intCantidadIngredientes;

        public int CantidadIngredientes {
            get { return _intCantidadIngredientes; }
            set { _intCantidadIngredientes = value; }
        }

        private string _strTamanio;

        public string Tamanio {
            get { return _strTamanio; }
            set { _strTamanio = value; }
        }

    }
}
