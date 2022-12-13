using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_5._3._2 {
    class Libro {
		
		private string _strNombre;

		public string Nombre {
			get { return _strNombre; }
			set { _strNombre = value;Evento("Se agrego el libro con nombre: " + value); }
		}

		public delegate void DelegadoEventHandler(string strMensaje);
		public event DelegadoEventHandler Evento;

		public override string ToString() {
			return "Nombre: " + Nombre; ;
		}
	}
}
