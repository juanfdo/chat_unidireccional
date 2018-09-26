using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace chat_sobre_sockets
{
    public class hilo_tcp
    {
        TcpClient socket_tcp = null;
        servidor_de_chat padre = null;
        public hilo_tcp(TcpClient socket_tcp, servidor_de_chat padre)
        {
            this.socket_tcp = socket_tcp;
            this.padre = padre;
        }
        public void proceso()
        {
            Byte[] bytes = new Byte[256];
            String data = null;
            int i;
            if (socket_tcp != null && padre != null)
            {
                while (true)
                {
                    data = null;
                    NetworkStream stream = this.socket_tcp.GetStream();

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        padre.agregar_mensaje(data);
                    }
                }
            }
        }
    }
    public class servidor_de_chat
    {
        Int32 puerto;
        IPAddress direccion_ip;
        private List<String> buffer_de_mensajes = null;

        TcpListener servidor = null;

        public servidor_de_chat(Int32 puerto = 666, String direccion_ip = "0.0.0.0")
        {
            this.puerto = puerto;
            this.direccion_ip = IPAddress.Parse(direccion_ip);
            this.servidor = new TcpListener(this.direccion_ip, this.puerto);
            this.servidor.Start();
        }
        public void escuchar()
        {
            hilo_tcp hijo;
            Thread nuevo_hilo;

            while (true)
            {
                TcpClient un_cliente = this.servidor.AcceptTcpClient();

                hijo = new hilo_tcp(un_cliente, this);
                nuevo_hilo = new Thread(new ThreadStart(hijo.proceso));
                nuevo_hilo.Start();
            }
        }
        public void agregar_mensaje(String mensaje)
        {
            if(buffer_de_mensajes == null)
                buffer_de_mensajes= new List<String>();
            buffer_de_mensajes.Add(mensaje);
        }
        public String retirar_mensaje()
        {
            String mensaje;
            try {
                mensaje = buffer_de_mensajes.ElementAt(0);
                buffer_de_mensajes.RemoveAt(0);
            }
            catch(ArgumentOutOfRangeException)
            {
                return null;
            }
            return mensaje;
        }
        public bool hay_mensajes_en_cola()
        {
            if (buffer_de_mensajes.Count > 0)
                return true;
            return false;
        }
    }
    public class cliente_de_chat
    {
        Int32 puerto = 0;
        String ip_del_servidor = null;
        TcpClient socket_cliente = null;
        NetworkStream flujo = null;

        public cliente_de_chat(Int32 puerto = 666, String ip_del_servidor = "127.0.0.1")
        {
            this.puerto = puerto;
            this.ip_del_servidor = ip_del_servidor;
            this.socket_cliente = new TcpClient(this.ip_del_servidor, this.puerto);
            this.flujo = this.socket_cliente.GetStream();
        }
        
        ~cliente_de_chat()
        {
            this.flujo.Close();
            this.socket_cliente.Close();
        }
        
        public void envia_mensaje(String mensaje)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(mensaje);
            this.flujo.Write(data, 0, data.Length);
        }
    }
}
