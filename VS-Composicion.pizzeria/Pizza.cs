using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_Composicion.pizzeria {
    class Pizza {
        private char _chrTamanio;

        public char Tamanio {
            get { return _chrTamanio; }
            set { _chrTamanio = value; }
        }

        private string _strIngredientes;

        public string Ingredientes {
            get { return _strIngredientes; }
            set { _strIngredientes = value; }
        }

    }
}
