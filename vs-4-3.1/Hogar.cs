using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_4._3._1 {
    class Hogar {
        private string _strPropietario;

        public string Propietario {
            get { return _strPropietario; }
            set { _strPropietario = value; }
        }

        private DateTime _dtmFechaRegistro;

        public DateTime FechaRegistro {
            get { return _dtmFechaRegistro; }
            set { _dtmFechaRegistro = value; }
        }

        private string _strNumeroExterior;

        public string NumeroExterior {
            get { return _strNumeroExterior; }
            set { _strNumeroExterior = value; }
        }

        private int _intNumeroHabitaciones;

        public int NumeroHabitaciones {
            get { return _intNumeroHabitaciones; }
            set { _intNumeroHabitaciones = value; }
        }
        private char _chrTamanio;

        public char Tamanio {
            get { return _chrTamanio; }
            set { _chrTamanio = value; }
        }

        private bool _blnEsDosPisos;

        public bool EsDosPisos {
            get { return _blnEsDosPisos; }
            set { _blnEsDosPisos = value; }
        }
    }
}
