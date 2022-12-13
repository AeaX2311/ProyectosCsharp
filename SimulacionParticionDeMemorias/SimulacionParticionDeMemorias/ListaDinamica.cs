using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimulacionParticionDeMemorias {
    class ListaDinamica {
        public ListaDinamica() {
            trabajos = new ArrayList();
        }

        private Unidad tamanioTotal;

        public Unidad TamanioTotal {
            get { return tamanioTotal; }
            set { tamanioTotal = value; }
        }

        private ArrayList trabajos;

        public ArrayList Trabajos {
            get { return trabajos; }
        }

        public bool TieneDisponibles() {
            foreach(TrabajoDinamico t in trabajos)
                if(t.isDisponible())
                    return true;

            return false;
        }

        private bool tieneParticionesLibres() {
            foreach(TrabajoDinamico t in trabajos) {
                if(t.isDisponible())
                    return true;
            }

            return false;
        }

        private int retornarPosicionMenorParaAsignar(Unidad unidad) {
            if(!TieneDisponibles())
                return -1;
           
            List<object[]> lista = new List<object[]>();

            int x = 0, y = -1;
            foreach(TrabajoDinamico t in trabajos) {
                if(t.isDisponible() && (t.TamanioTotal.compareTo(unidad) == 1 || t.TamanioTotal.compareTo(unidad) == 0)) {
                    object[] o = new object[2];
                    o[0] = t.TamanioTotal;
                    o[1] = x;
                    lista.Add(o);
                    y++;
                }

                x++;
            }

            Unidad aux = (Unidad)lista[y][0];
            int pos = (int)lista[y][1];

            for(int z = y; z >= 0; z--) {
                object[] o = lista[z];
                if(aux.compareTo((Unidad) o[0]) == 1 || aux.compareTo((Unidad) o[0]) == 0) {
                    aux = (Unidad) o[0];
                    pos = (int) o[1];
                    x = -1;
                }
            }
            /*foreach(object[] o in lista) { 
                if(aux.compareTo((Unidad)o[0]) == 1 || aux.compareTo((Unidad) o[0]) == 0) {
                    aux = (Unidad)o[0];
                    pos = (int)o[1];
                    x = -1;
                }
            }*/

        
            if(x != -1)        
                  return -1;

            return pos;
        }

        /*public Unidad obtenerMemoriaDisponible() {
            Unidad aux = new Unidad(0, "GB");

            foreach(TrabajoDinamico t in trabajos) {
                if(t.isDisponible())
                    aux = aux.sumar(t.TamanioOcupado);
            }

            return aux;
        }*/
     
        public Unidad obtenerDisponibleParaAsignar() {
            Unidad aux = new Unidad(0,"GB");

            foreach(TrabajoDinamico t in trabajos) {
                aux = aux.sumar(t.TamanioTotal);
            }

            return TamanioTotal.restar(aux);
        }

        public int findPosition(string id) {
            int x = 0;
            foreach(TrabajoDinamico t in trabajos) {
                if(t.Id.Equals(id)) return x;
                x++;
            }

            return -1;
        }

        public void agregarSO(Trabajo SO) {
            trabajos.Add(new TrabajoDinamico(SO.Tamanio, SO.Id));
        }

        /*
         -1 => trabajo se asigna en nunca
          0 => se pone en espera
          1 => se asigno
         */
        public int agregarTrabajo(Trabajo nuevoTrabajo) {
            if(nuevoTrabajo.Tamanio.compareTo(TamanioTotal.restar(((TrabajoDinamico) trabajos[0]).TamanioTotal)) == 1)
                return -1;

            if(tieneParticionesLibres()) {
                int pos = retornarPosicionMenorParaAsignar(nuevoTrabajo.Tamanio);

                if(pos == -1)
                    return 0;

                ((TrabajoDinamico) trabajos[pos]).Id = nuevoTrabajo.Id;
                ((TrabajoDinamico) trabajos[pos]).TamanioOcupado = nuevoTrabajo.Tamanio;

                return 1;
            } else if(nuevoTrabajo.Tamanio.compareTo(obtenerDisponibleParaAsignar()) == -1 || nuevoTrabajo.Tamanio.compareTo(obtenerDisponibleParaAsignar()) == 0) { //cabe){   
                trabajos.Add(new TrabajoDinamico(nuevoTrabajo.Tamanio, nuevoTrabajo.Id));
                return 1;
            } else {
                return 0;
            }
        }

        public int quitarTrabajo(string idTrabajo) {
            int pos = findPosition(idTrabajo);
            if(pos == -1 || pos == 0)
                throw new Exception("El trabajo " + idTrabajo + " no se encontro en los trabajos asignados o no se puede eliminar.");

              //asignar id a null
            // quitar SOLO tamanio ocupado
            ((TrabajoDinamico) trabajos[pos]).Id = "S/T";
            ((TrabajoDinamico) trabajos[pos]).TamanioOcupado = new Unidad();

            try {
                if(pos != trabajos.Count - 1 && ((TrabajoDinamico) trabajos[pos + 1]).isDisponible()) { //compactr
                    TrabajoDinamico deleted = (TrabajoDinamico) trabajos[pos + 1];
                    ((TrabajoDinamico) trabajos[pos]).TamanioTotal = ((TrabajoDinamico) trabajos[pos]).TamanioTotal.sumar(deleted.TamanioTotal);
                    trabajos.RemoveAt(pos + 1);
                    MessageBox.Show("Se compacto la memoria.");
                } else if(((TrabajoDinamico) trabajos[pos - 1]).isDisponible()) {
                    TrabajoDinamico deleted = (TrabajoDinamico) trabajos[pos - 1];
                    ((TrabajoDinamico) trabajos[pos]).TamanioTotal = ((TrabajoDinamico) trabajos[pos]).TamanioTotal.sumar(deleted.TamanioTotal);
                    trabajos.RemoveAt(pos - 1);
                    MessageBox.Show("Se compacto la memoria.");
                    return pos - 1;
                }
            } catch(Exception) {
                return pos;
            }

            return pos;
        }
    }
}
