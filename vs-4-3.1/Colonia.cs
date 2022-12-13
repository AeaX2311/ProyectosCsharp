using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_4._3._1 {
    class Colonia {
        public Colonia(string strNombre, char chrUbicacion) {
            Nombre = strNombre;
            Ubicacion = chrUbicacion;
            _listaHogares = new List<Hogar>();
        }

        private string _strNombre;

        public string Nombre {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private char _chrUbicacion;

        public char Ubicacion {
            get { return _chrUbicacion; }
            set { _chrUbicacion = value; }
        }

        private List<Hogar> _listaHogares;

        public void InsertarHogar(Hogar nuevoHogar) {
            if(nuevoHogar!=null)
                _listaHogares.Add(nuevoHogar);
        }

        public int ContarHogares() {
            return _listaHogares.Count;
        }

        public int ContarHabitaciones() {
            int intAux = 0;

            foreach(Hogar h in _listaHogares) {
                intAux += h.NumeroHabitaciones;
            }

            return intAux;
        }

        public IEnumerator<Hogar> GetEnumerator() {
            return _listaHogares.GetEnumerator();
        }
    }
}
