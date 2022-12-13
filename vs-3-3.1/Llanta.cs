using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_3._3._1 {
    class Llanta {
        public Llanta(string strMarca) {
            Marca = strMarca;
        }

        private string _strMarca;

        public string Marca{
            get {
                if(_strMarca!=null)
                return _strMarca;
                return "";
            }
            set { _strMarca = value; }
        }
        
        public override string ToString() {
            return "Llanta: " + Marca;
        }

    }
}
