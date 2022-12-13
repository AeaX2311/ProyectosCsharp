using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionParticionDeMemorias {
    class Unidad {
        public Unidad() {
            Cantidad = 0;
            Tipo = "KB";
        }

        public Unidad(double cantidad, string tipo) {
            Cantidad = cantidad;
            Tipo = tipo;
        }

        private double cantidad;

        public double Cantidad {
            get { return cantidad; }
            set {
                if(value < 0)
                    value = 0;
                cantidad = value; 
            }
        }

        private string tipo;

        public string Tipo {
            get { return tipo; }
            set {
                if(!value.Equals("GB") && !value.Equals("MB") && !value.Equals("KB"))
                    value = "GB";
                tipo = value; 
            }
        }

        public override string ToString() {
            return Cantidad + " " + Tipo;
        }

        public double obtenerMB() {
            if(tipo.Equals("GB"))
                return cantidad * 1024;

            if(tipo.Equals("KB"))
                return cantidad / 1024;

            return cantidad;
        }

        public Unidad optimizarTipo() {
            Unidad u = new Unidad(obtenerMB(), "MB");

            if(u.cantidad >= 1024) {
                u.cantidad /= 1024;
                u.tipo = "GB";
            } else if(u.cantidad < 1)  {
                u.cantidad *= 1024;
                u.tipo = "KB";
            }

            cantidad = u.cantidad;
            tipo = u.tipo;
            
            return this;
        }

        public int compareTo(Unidad otra) {
            if(otra == null)
                return 1;

            if(otra.obtenerMB() == obtenerMB())
                return 0;

            if(obtenerMB() > otra.obtenerMB())
                return 1;

            return -1;
        }

        public Unidad restar(Unidad otra) {
            if(otra == null)
                return this;

            Unidad u = new Unidad(obtenerMB() - otra.obtenerMB(), "MB");

            if(u.cantidad >= 1024) {
                u.cantidad /= 1024;
                u.tipo = "GB";
            }else if(u.cantidad < 1) {
                u.cantidad *= 1024;
                u.tipo = "KB";
            }

            return u;
        }

        public Unidad sumar(Unidad otra) {
            if(otra == null)
                return this;

            Unidad u = new Unidad(obtenerMB() + otra.obtenerMB(), "MB");

            if(u.cantidad >= 1024) {
                u.cantidad /= 1024;
                u.tipo = "GB";
            } else if(u.cantidad < 1) {
                u.cantidad *= 1024;
                u.tipo = "KB";
            }

            return u;
        }
    }
}
