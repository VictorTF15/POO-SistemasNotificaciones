using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            string Mensaje = textBox2.Text;

            Usuario usuario = new Usuario(Nombre);
            Notificador notificador = new Notificador();

            notificador.Suscribir(usuario);
            notificador.Notificar(Mensaje);

            notificador.Desuscribir(usuario);
            notificador.Notificar(Mensaje);
        }
    }
}
