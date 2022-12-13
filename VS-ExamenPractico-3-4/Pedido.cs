using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace VS_ExamenPractico_3_4 {
    class Pedido : IComparable<Pedido> {
        private int _intUnidadesSolicitadas;

        public int UnidadesSolicitadas {
            get { return _intUnidadesSolicitadas; }
            set { _intUnidadesSolicitadas = value; }
        }

        private string _strCodigo;

        public string Codigo {
            get { return _strCodigo; }
            set { _strCodigo = value; }
        }

        private double _dblCostoPorUnidad;

        public double CostoPorUnidad {
            get { return _dblCostoPorUnidad; }
            set { _dblCostoPorUnidad = value; }
        }

        public int CompareTo(Pedido otroPedido) {
            if (UnidadesSolicitadas > otroPedido.UnidadesSolicitadas) return 1;
            else if (UnidadesSolicitadas < otroPedido.UnidadesSolicitadas) return -1;
            else return 0;
        }
    }
}
