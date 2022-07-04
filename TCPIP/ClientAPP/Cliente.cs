using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

//ELIMINAR Librerias preincluidas en C#
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

// https://developpaper.com/c-open-source-class-library-simpletcp/
namespace ClientAPP
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se crea al objeto
            client = new SimpleTcpClient();

            //Se crea el separador, 0x13 es el valor por defecto
            client.Delimiter = 0x13;

            //Creamos el formato de decodificacion, UTF8 es el que viene por defecto
            client.StringEncoder = Encoding.UTF8;
            
            //Recibimos los datos
            client.DataReceived += Client_DataReceived;
        }
        
        //Metodo para recibir datos
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Status.Invoke((MethodInvoker)delegate ()
            {
                txt_Status.Text += e.MessageString;
            });
        }

        //Boton que conecta el cliente con el servidor
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            //Desactiva el boton una vez que este es pulsado
            btn_Conectar.Enabled = false;

            //Obtiene el numero del puerto de la conexion
            client.Connect(txt_Host.Text, Convert.ToInt32(txt_Port.Text));
        }

        //Boton que envia un texto del cliente al servidor
        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txt_Mensaje.Text, TimeSpan.FromSeconds(2));
        }

    }
}
