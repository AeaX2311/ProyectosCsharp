using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_Composicion.pizzeria {
    class Orden :IEquatable<Orden>{
        public Orden(int intNumeroOrden) {
            NumeroOrden = intNumeroOrden;
        }
        private DateTime _dtmFechaEntrega;

        public DateTime FechaEntrega{
            get { return _dtmFechaEntrega; }
            set { _dtmFechaEntrega = value; }
        }

        public int NumeroOrden { get; }

        private Pizza _tipoPizza;

        public Pizza TipoPizza {
            get { return _tipoPizza; }
            set { _tipoPizza = value; }
        }

        private bool _blnPagada;

        public bool Pagada {
            get { return _blnPagada; }
            set { _blnPagada = value; }
        }

        public bool Equals(Orden otraOrden) {
            if (otraOrden == null) return false;

            return this.NumeroOrden == otraOrden.NumeroOrden; 
        }
            
        ~Orden() {
            TipoPizza = null;
        }
    }
}
