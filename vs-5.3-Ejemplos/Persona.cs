using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_5._3_Ejemplos {
    class Persona {
        private string _strNombre;

        public string Nombre {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        public int CalcularEdad() {
            TimeSpan intervalo= DateTime.Now - this.FechaNacimiento;
            return (int)(intervalo.Days/365.25);
        }
    }
}
