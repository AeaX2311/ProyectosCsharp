using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace VS_5._3._3 {
    public partial class Form1 : Form {
        Termostato miTermostato = new Termostato();

        /*                               EJERCICIO 3
         * Cree una cuenta para realizar los envios de los mensajes, si gusta puede poner otra.
         * 
         * DUDA
         * 
         * En las diapositivas se muestra que al utilizar la interfase INotifyPropertyChanged
         * solamente hay una clase publicadora y no hay clase suscriptora (es la misma)
         * 
         */ 

        private void MetodoGestor(object sender, PropertyChangedEventArgs e) {
            try {
                MailMessage miMensaje = new MailMessage();

                //Puede poner su correo :D
                miMensaje.To.Add(new MailAddress("alan.ssuc2311@gmail.com"));


                miMensaje.From = new MailAddress("cuenta.ejercicios.mensajes@gmail.com");
                miMensaje.Subject = "AVISO | Temperatura";
                miMensaje.Body = "La temperatura ambiente es inferior a los 20°C, le sugerimos que tome las medidas necesarias.\n"+
                                 "Temperatura registrada: "+ miTermostato.TemperaturaAmbiente+ "°C";

                SmtpClient miCliente = new SmtpClient("smtp.gmail.com", 25);
                miCliente.Credentials = new System.Net.NetworkCredential("cuenta.ejercicios.mensajes@gmail.com", "A1b2C3d4");   
                miCliente.EnableSsl = true;
                miCliente.Send(miMensaje);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    
        public Form1() {
            InitializeComponent();
            lblAccion.Text = "OFF"; groupBox2.BackColor = Color.Red;
            miTermostato.PropertyChanged += new PropertyChangedEventHandler(MetodoGestor);
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            try {
                miTermostato.TemperaturaAmbiente = int.Parse(txtTemperaturaAmbiente.Text);
            } catch {
                MessageBox.Show("Favor de rellenar los campos");
                return;
            } finally {
                txtTemperaturaAmbiente.Focus();
                txtTemperaturaAmbiente.Clear();
            }

            if (miTermostato.TemperaturaAmbiente > 79 && !miTermostato.Encendido) {
                lblAccion.Text = "ON"; groupBox2.BackColor = Color.Green;
                Iniciar();
            }else if (miTermostato.TemperaturaAmbiente < 51 && miTermostato.Encendido) {
                lblAccion.Text = "OFF"; groupBox2.BackColor = Color.Red;
                Apagar();
            }

            listView1.Items.Add("Temperatura: " + miTermostato.TemperaturaAmbiente + "°C");
        }
        private void Iniciar() {
            MessageBox.Show("El termostato a iniciado su proceso de enfriamiento.");
            miTermostato.Encendido = true;
        }

        private void Apagar() {
            MessageBox.Show("Se apago el termostato.");
            miTermostato.Encendido = false;
        }
    }
}
