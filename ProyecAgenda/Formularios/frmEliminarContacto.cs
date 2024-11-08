using ProyecAgenda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAgenda.Formularios
{
    public partial class frmEliminarContacto : Form
    {
        public frmEliminarContacto()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Contactos EliminarDatos()
        {
            Contactos contac = new Contactos();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;

            contac.Nombre = nombre;
            contac.Apellido = apellido;
            contac.Correo = correo;
            return contac;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            ConexionBD contacto = new ConexionBD();
            contacto.Eliminar(EliminarDatos());
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            Close();
        }
    }
}
