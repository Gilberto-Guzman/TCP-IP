using SimpleTCP;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

//ELIMINAR Librerias preincluidas en C#
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace TCPIP
{
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se crea al objeto
            server = new SimpleTcpServer();
            
            //Se crea el separador, 0x13 es el valor por defecto
            server.Delimiter = 0x13;
            
            //Creamos el formato de decodificacion, UTF8 es el que viene por defecto
            server.StringEncoder = Encoding.UTF8;

            //Recibimos los datos
            server.DataReceived += DataReceived;
        }
        
        //Metodo para recibir datos
        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Status.Invoke((MethodInvoker)delegate ()
            {
                //Agregamos el mensaje a nuestro cuadro llamado txt_Status
                txt_Status.Text = txt_Status.Text + e.MessageString;
                //txt_Status.Text += e.MessageString;

                //Muestra el mensaje del cliente en pantalla
                e.ReplyLine(string.Format("Mensaje: {0} ",e.MessageString));
            });
        }

        //Boton que inicia el servidor
        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            txt_Status.Text += "Iniciando la comunicacion con el servidor...";
            IPAddress ip = IPAddress.Parse(txthost.Text);
            server.Start(ip, Convert.ToInt32(txt_Port.Text));
        }

        //Boton que detiene el servidor
        private void btn_Detener_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
