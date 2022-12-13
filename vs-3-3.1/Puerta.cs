using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_3._3._1 {
    class Puerta {
        public Puerta(string strTipo) {
            Tipo = strTipo;
        }

        private string _strTipo;

        public string Tipo {
            get { return _strTipo; }
            set { _strTipo = value; }
        }

    }
}
