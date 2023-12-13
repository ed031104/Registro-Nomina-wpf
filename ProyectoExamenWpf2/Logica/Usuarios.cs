using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoExamenWpf2.Logica
{
    public class Usuarios : Persona
    {
        String contraseña;

        public Usuarios(string nombre, string email, string telefono, string apellidos, string fechaNacimiento, string contraseña) : base(nombre, email, telefono, apellidos, fechaNacimiento)
        {
            this.contraseña = contraseña;
        }

        public String Contraseña { get { return contraseña; } set { contraseña = value; } }
       
    }
}
