using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using chat_sobre_sockets;

namespace ejemplo_de_servidor
{
    public partial class ejemplo_de_servidor : Form
    {
        servidor_de_chat servidor=null;
        public ejemplo_de_servidor()
        {
            InitializeComponent();
        }

        private void ejemplo_de_servidor_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        public void crea_hilo_de_servidor()
        {
            servidor = new servidor_de_chat();
            servidor.escuchar();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if(servidor == null) { 
                Thread nuevo_hilo = new Thread(new ThreadStart(this.crea_hilo_de_servidor));
                nuevo_hilo.Start();
            }
        }

        private void btLeer_Click(object sender, EventArgs e)
        {
            if(servidor!=null)
            { 
                if (servidor.hay_mensajes_en_cola())
                {
                    String tmp = servidor.retirar_mensaje();
                    rtbMensajes.Text += "\r\n" + tmp;
                }
            }
        }
    }
}
