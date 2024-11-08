using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecAgenda.Clases
{
    internal class ArchivoContactos
    {
        public string Archivo = "Contactos.csv";

        public void Grabar (string nombre, string apellido, int telefono, string correo, string categoria)
        {
            StreamWriter Ar = new StreamWriter(Archivo , true );

            Ar.WriteLine(nombre);
            Ar.WriteLine(";");
            Ar.WriteLine(apellido);
            Ar.WriteLine(";");
            Ar.WriteLine(telefono);
            Ar.WriteLine(";");
            Ar.WriteLine(correo);
            Ar.WriteLine(";");

            Ar.WriteLine(categoria);

            Ar.Close();
            Ar.Dispose();
        }
    }
}
