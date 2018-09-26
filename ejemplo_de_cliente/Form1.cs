using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chat_sobre_sockets;

namespace ejemplo_de_cliente
{
    public partial class ejemplo_de_cliente : Form
    {
        cliente_de_chat cliente;
        public ejemplo_de_cliente()
        {
            InitializeComponent();
        }

        private void ejemplo_de_cliente_Load(object sender, EventArgs e)
        {
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            cliente = new cliente_de_chat();
        }

        private void btEnvia_Click(object sender, EventArgs e)
        {
            cliente.envia_mensaje(tbMensaje.Text);
        }
    }
}
