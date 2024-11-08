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
    public partial class frmAgregarContacto : Form
    {
        public frmAgregarContacto()
        {
            InitializeComponent();
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Amigos");
            cmbCategoria.Items.Add("Familia");
            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.SelectedIndex = -1;

            tvAgregar.Nodes.Clear();
            tvAgregar.Nodes.Add("Amigos");
            tvAgregar.Nodes.Add("Familia");
            tvAgregar.Nodes.Add("Trabajo");

        }
       private Contactos guardarDatos()
       {
            Contactos contactoNuevo = new Contactos();

            contactoNuevo.Nombre = txtNombre.Text;
            contactoNuevo.Apellido = txtApellido.Text;
            contactoNuevo.Telefono = int.Parse(txtTelefono.Text);
            contactoNuevo.Correo = txtCorreo.Text;

            if (cmbCategoria.SelectedItem != null)
            {
                contactoNuevo.Categoria = cmbCategoria.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una Categoria");
                return null;
            }
            return contactoNuevo;
       }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Contactos nuevocontacto = guardarDatos();
            if (nuevocontacto != null)
            {
                ConexionBD ContactoNuevo = new ConexionBD();
                ContactoNuevo.Agregar(nuevocontacto, tvAgregar);
            }
            ConexionBD basedatos = new ConexionBD();
            basedatos.MostrarTree(tvAgregar);
        }
    }
}
