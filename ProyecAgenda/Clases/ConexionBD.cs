using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAgenda.Clases
{
    internal class ConexionBD
    {
        //creamos objeto para conectarnos con la bd
        private OleDbConnection conexion = new OleDbConnection();
        //para enviar las ordenes a la bd 
        private OleDbCommand comando = new OleDbCommand();
        //nos sirve para adaptar los datos que estan mal en la bd   
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ProyectAgenda\ProyecAgenda\bin\Debug\DataBase;";

        private string Tabla = "Agenda";


        // metodo conexion
        public void conexiones()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        // metodo prueba
        public void ProbarConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Conexión a la base de datos exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        // metodo para el treeview
        public void MostrarTree(TreeView treeView)
        {
            try
            {
                conexiones();

                string query = "SELECT Nombre, Apellido, Telefono, Correo, Categoria FROM Agenda";
                comando.CommandText = query;
                OleDbDataReader reader = comando.ExecuteReader();

                treeView.Nodes.Clear();

                while (reader.Read())
                {
                    string categoria = reader["Categoria"].ToString();
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    string correo = reader["Correo"].ToString();
                    string telefono = reader["Telefono"].ToString();
                    TreeNode categoriaNode = treeView.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == categoria);

                    if (categoriaNode == null)
                    {
                        categoriaNode = new TreeNode(categoria);
                        treeView.Nodes.Add(categoriaNode);
                    }

                    var contacto = new Contactos
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Telefono = int.TryParse(telefono, out int telefonoInt) ? telefonoInt : 0,
                        Correo = correo,
                        Categoria = categoria,
                    };

                    TreeNode contactoNode = new TreeNode($"{nombre} {apellido}");
                    contactoNode.Tag = contacto;
                    categoriaNode.Nodes.Add(contactoNode);

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contactos: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        // metodo para agregar nuevo contacto
        public void Agregar(Contactos contacto, TreeView treeView)
        {
            try
            {
                conexiones();

                string query = "INSERT INTO Agenda (Nombre, Apellido, Telefono, Correo, Categoria) VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Categoria)";

                comando.CommandText = query;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                comando.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                comando.Parameters.AddWithValue("@Correo", contacto.Correo);
                comando.Parameters.AddWithValue("@Categoria", contacto.Categoria);
                // ejecuta la query
                comando.ExecuteNonQuery();

                MessageBox.Show("Contacto agregado correctamente.");

                AgregarContactoAlTreeView(contacto, treeView);

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN BD " + e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        // metodo para agregar al treeview
        private void AgregarContactoAlTreeView(Contactos contacto, TreeView treeView)
        {
            TreeNode categoriaNode = null;

            foreach (TreeNode nodo in treeView.Nodes)
            {
                if (nodo.Text == contacto.Categoria)
                {
                    categoriaNode = nodo;
                    break;
                }
            }

            if (categoriaNode != null)
            {
                TreeNode contactoNode = new TreeNode($"{contacto.Nombre} {contacto.Apellido}");

                categoriaNode.Nodes.Add(contactoNode);
            }
            else
            {
                MessageBox.Show("La categoría no existe en el TreeView.");
            }
        }

        // metodo eliminar 
        public void Eliminar(Contactos contacto)
        {
            try
            {
                conexiones();
                comando.CommandText = "DELETE FROM Agenda where Nombre = @Nombre AND Apellido = @Apellido AND Correo = @Correo";

                comando.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                comando.Parameters.AddWithValue("@Correo", contacto.Correo);

                comando.ExecuteNonQuery();

                MessageBox.Show("Eliminado Correctamente.");

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN BD " + e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        // metodos buscar 
        public DataTable BuscarPorNombre(string nombre)
        {
            conexiones();

            string query = "SELECT * FROM Agenda WHERE Nombre = @Nombre";
            comando.CommandText = query;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Nombre", nombre);

            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable resultados = new DataTable();
            adaptador.Fill(resultados);

            conexion.Close();
            return resultados;
        }

        public DataTable BuscarPorApellido(string apellido)
        {
            conexiones();

            string query = "SELECT * FROM Agenda WHERE Nombre = @Nombre";
            comando.CommandText = query;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Apellido", apellido);

            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable resultados = new DataTable();
            adaptador.Fill(resultados);

            conexion.Close();
            return resultados;
        }

        public DataTable BuscarPorCorreo(string correo)
        {
            conexiones();

            string query = "SELECT * FROM Agenda WHERE Correo = @Correo";
            comando.CommandText = query;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Correo", correo);

            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable resultados = new DataTable();
            adaptador.Fill(resultados);

            conexion.Close();
            return resultados;
        }

        public DataTable BuscarPorTelefono(int telefono)
        {
            conexiones();

            string query = "SELECT * FROM Agenda WHERE Telefono = @Telefono";
            comando.CommandText = query;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Telefono", telefono);

            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable resultados = new DataTable();
            adaptador.Fill(resultados);

            conexion.Close();
            return resultados;
        }

        public DataTable BuscarPorCategoria(string categoria)
        {
            conexiones();

            string query = "SELECT * FROM Agenda WHERE Nombre = @Nombre";
            comando.CommandText = query;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Categoria", categoria);

            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable resultados = new DataTable();
            adaptador.Fill(resultados);

            conexion.Close();
            return resultados;
        }

        public void Modificar(Contactos contactoNuevo)
        {
            try
            {
                conexiones();

                comando.CommandText = "UPDATE Agenda SET Nombre = ?, Apellido  = ?, Telefono = ?, Correo = ?, Categoria = ? WHERE Telefono = ?";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("?", contactoNuevo.Nombre);
                comando.Parameters.AddWithValue("?", contactoNuevo.Apellido);
                comando.Parameters.AddWithValue("?", contactoNuevo.Telefono);
                comando.Parameters.AddWithValue("?", contactoNuevo.Correo);
                comando.Parameters.AddWithValue("?", contactoNuevo.Categoria);

                comando.Parameters.AddWithValue("?", contactoNuevo.Telefono);

                comando.ExecuteNonQuery();

                MessageBox.Show("Modificado correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN BD " + e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
