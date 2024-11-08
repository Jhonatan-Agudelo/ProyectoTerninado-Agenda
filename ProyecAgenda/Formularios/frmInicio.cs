using ProyecAgenda.Clases;
using ProyecAgenda.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAgenda
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Amigos");
            cmbCategoria.Items.Add("Familia");
            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.SelectedIndex = -1;

            TvContactos.Nodes.Add("Amigos");
            TvContactos.Nodes.Add("Familia");
            TvContactos.Nodes.Add("Trabajo");
        }
        //ArchivoContactos ExportarContacto = new ArchivoContactos();

        //private void cmdExportar_Click(object sender, EventArgs e)
        
            //string categoria = cmbCategoria.Text;
            //int telefono = int.Parse(txtTelefono.Text);

            //ExportarContacto.Grabar(txtNombre.Text, txtApellido.Text, telefono, categoria);
            //MessageBox.Show("Datos Listos para Exportar");

        

        private Contactos guardar()
        {
            Contactos NuevosContact = new Contactos();

            NuevosContact.Nombre = txtNombre.Text;
            NuevosContact.Apellido = txtApellido.Text;
            NuevosContact.Telefono = int.Parse(txtTelefono.Text);
            NuevosContact.Correo = txtCorreo.Text;

            if(cmbCategoria.SelectedItem != null) 
            {
                NuevosContact.Categoria = cmbCategoria.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una Categoria");
                return null;
            }
            return NuevosContact;
        }

        private void cmdAgregarContacto_Click(object sender, EventArgs e)
        {
            frmAgregarContacto frmagregar = new frmAgregarContacto();
            this.Hide();
            frmagregar.ShowDialog();
            this.Show();
        }

        private void cmdModifContacto_Click(object sender, EventArgs e)
        {
            ConexionBD modifContacto = new ConexionBD();
            modifContacto.Modificar(guardar());
        }

        private void cmdEliminarContacto_Click(object sender, EventArgs e)
        {
            frmEliminarContacto frmElim = new frmEliminarContacto();
            this.Hide();
            frmElim.ShowDialog();
            this.Show();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            DataTable Resultado = new DataTable();

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                string nombre = txtNombre.Text;
                Resultado = conexion.BuscarPorNombre(nombre);
            }
            if (!string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                string apellido = txtApellido.Text;
                Resultado = conexion.BuscarPorApellido(apellido);
            }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && int.TryParse(txtTelefono.Text, out int telefono))
            {
                Resultado = conexion.BuscarPorTelefono(telefono);
            }
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                string correo = txtCorreo.Text;
                Resultado = conexion.BuscarPorCorreo(correo);
            }
            if (!string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                string categoria = cmbCategoria.Text;
                Resultado = conexion.BuscarPorCategoria(categoria);
            }
        }
    }
}
