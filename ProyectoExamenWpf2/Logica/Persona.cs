using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoExamenWpf2.Logica
{
    public class Persona
    {
        //atributos
        private String nombre,  email, telefono, apellidos, fechaNacimiento;

        //constructor con argumentos
        public Persona(String nombre, String email, String telefono, String apellidos, String fechaNacimiento) { 
            this.nombre = nombre;
            this.email = email;
            this.telefono = telefono;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
        }

        //set y get
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String Telefono { get { return telefono; } set { telefono = value; } }
        public String Apellidos { get { return apellidos; } set { apellidos = value; } }
        public String FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }


    }
}
