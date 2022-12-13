using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos {
    class Program {
        static string strNombreArchivo = "C:\\Users\\alans\\Desktop\\ArchivoDeDatos.txt";
        static void Main(string[] args) {
            int leer = 0;
            do {
                Console.WriteLine("+-----OPCIONES-----+");
                Console.WriteLine("[0]-Salir");
                Console.WriteLine("[1]-Agregar");
                Console.WriteLine("[2]-Mostrar");
                Console.WriteLine("[3]-Borrar todo");
                leer = int.Parse(Console.ReadLine());

                switch (leer) {
                    case 0: Console.WriteLine("\nPresione cualquier tecla para salir..."); break;
                    case 1: Agregar();break;
                    case 2: Mostrar();break;
                    case 3: Borrar();break;
                    default: break;
                }
            } while (leer !=0);

            Console.ReadKey();
        }

        public static void Borrar() {
            File.Delete(strNombreArchivo);
            Console.WriteLine("\n   Se borraron todos los datos.");
        }

        public static void Mostrar() {
            StreamReader flujoLectura = new StreamReader(strNombreArchivo);

            Console.WriteLine("\n------------------------------------------------------------");

      //      if (flujoLectura == null) { Console.WriteLine("No hay ningun dato"); return; }
            while(!flujoLectura.EndOfStream){
                Console.WriteLine("   +- "+flujoLectura.ReadLine());
            }

            Console.WriteLine("------------------------------------------------------------\n");
            if (flujoLectura != null) flujoLectura.Close();
        }

        public static void Agregar() {
            Console.Write("Ingrese el texto que desea agregar:\n+- ");
            string texto = Console.ReadLine();

            StreamWriter flujoEscritura = null; FileStream flujo = null;

            if (File.Exists(strNombreArchivo)) {
                flujo = new FileStream(strNombreArchivo,FileMode.Append);
                flujoEscritura = new StreamWriter(flujo);
            } else {
                flujoEscritura = new StreamWriter(strNombreArchivo);
            }

            Console.WriteLine("\n   Se agrego el dato de manera exitosa.");
            flujoEscritura.WriteLine(texto);

            if (flujoEscritura != null) flujoEscritura.Close();
            if (flujo != null) flujo.Close();
        }
    }

}
