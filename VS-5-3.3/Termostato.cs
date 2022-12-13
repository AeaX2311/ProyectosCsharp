using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_5._3._3 {
    class Termostato : INotifyPropertyChanged {
		/*
		 * Basada en que cuando el mecanismo llegue a los 80C se inicie para regular la temperatura
		 * El termostato se apaga al llegar a 50C
		 */

		public Termostato() {
			Encendido = false;
		}

		private int _intTemperaturaAmbiente;

		public int TemperaturaAmbiente {
			get { return _intTemperaturaAmbiente; }
			set {
				_intTemperaturaAmbiente = value; 

				if (_intTemperaturaAmbiente < 21)
					NotificarCambio();
			}
		}

		private bool _blnEncendido;

		public bool Encendido {
			get { return _blnEncendido; }
			set { _blnEncendido = value; }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotificarCambio() {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(TemperaturaAmbiente.ToString()));
		}
	}
}
