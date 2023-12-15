using ProyectoExamenWpf2.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoExamenWpf2
{
    public partial class RegistroNomina : Page
    {

        
        public RegistroNomina()
        {
            InitializeComponent();
            
        }

        public void llenarComboBox(ListaEmpleados listaEmpleados) {
        
            List<Empleados> listaempleado = listaEmpleados.listaEmpleado;

            for (int i = 0; i < listaempleado.Count; i++)
            {
                Empleados empleado = listaempleado[i];

                EmpleadoCB.Items.Add(empleado);

            }
        }
    }
}
