using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoExamenWpf2.Logica
{
    public class Empleados : Persona
    {
        String sexo, numeroCedula, cargo;
        int numeroInss;
        double salarioMensual;

        public Empleados(string nombre, string email, string telefono, string apellidos, string fechaNacimiento, String sexo, String numeroCedula, String cargo, int numeroInss, double salarioMensual) : base(nombre, email, telefono, apellidos, fechaNacimiento)
        {
            this.sexo = sexo;
            this.numeroCedula = numeroCedula;
            this.cargo = cargo;
            this.numeroInss = numeroInss;
            this.salarioMensual = salarioMensual;
        }

        public String Sexo { get { return sexo; } set { sexo= value; } }
        public String NumeroCedula { get { return numeroCedula; } set { numeroCedula= value; } }
        public String Cargo { get { return cargo; } set { cargo= value; } }
        public int NumeroInss { get { return numeroInss; } set { numeroInss= value; } }
        public double SalarioMensual { get { return salarioMensual; } set { salarioMensual= value; } }








    }
}
