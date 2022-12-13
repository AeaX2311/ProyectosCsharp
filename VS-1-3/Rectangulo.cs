using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_1._3 {
    class Rectangulo {
        private double _dblLargo;
        private double _dblAncho;

        public double CalcularArea() {
            return _dblLargo* _dblAncho;
        }

        public void ModificarLargo(double largo) {
            _dblLargo = largo;
        }
        public void ModificarAncho(double ancho) {
            _dblAncho = ancho;
        }
        public double ConsultarLargo() {
            return _dblLargo;
        }
        public double ConsultarAncho(double ancho) {
            return _dblAncho;
        }
    }
}
