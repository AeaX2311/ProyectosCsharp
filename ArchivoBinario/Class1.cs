using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArchivoBinario
{
    public class ArchivoSecuencialSerializadoBinario<T> {
		public ArchivoSecuencialSerializadoBinario(string strNombreArchivo) {
			NombreArchivo = strNombreArchivo;
		}

		private string _strNombreArchivo;

		public string NombreArchivo {
			get { return _strNombreArchivo; }
			set { _strNombreArchivo = value; }
		}

		FileStream flujo;
		BinaryFormatter seriador;

		public void Crear() {
			flujo = new FileStream(NombreArchivo, FileMode.Create);
			seriador = new BinaryFormatter();
		}

		public void AbrirModoEscritura() {
			if (File.Exists(NombreArchivo)) {
				flujo = new FileStream(NombreArchivo, FileMode.Append);
				seriador = new BinaryFormatter();
			} else 
				Crear();
		}

		public bool AbiriModoLectura() {
			if (File.Exists(NombreArchivo)) {
				flujo = new FileStream(NombreArchivo, FileMode.Open);
				seriador = new BinaryFormatter();
				return true;
			}

			return false;
		}

		public void AbrirModoLecturaYEscritura() {
			if (File.Exists(NombreArchivo)) {
				flujo = new FileStream(NombreArchivo, FileMode.Open, FileAccess.ReadWrite);
				seriador = new BinaryFormatter();
			} else
				Crear();
		}

		public void GrabarObjeto(T nuevoObjeto) {
			seriador.Serialize(flujo,nuevoObjeto);
		}

		public T LeerOjeto() {
			return (T)seriador.Deserialize(flujo);
		}

		public void Cerrar() {
			if (flujo != null)
				flujo.Close();
		}

		public void EliminarArchivo() {
			File.Delete(NombreArchivo);
        }
		 
		~ArchivoSecuencialSerializadoBinario() {
			Cerrar();
		}

		public bool Existe() {
			return File.Exists(NombreArchivo);
		}

	}
}
