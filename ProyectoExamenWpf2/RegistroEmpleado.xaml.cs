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
using System.Windows.Shapes;

namespace ProyectoExamenWpf2
{

    public partial class RegistroEmpleado : Page
    {

        ListaEmpleados listaEmpleados = new ListaEmpleados();


        RegistroNomina vistaNomina;
        public RegistroEmpleado(RegistroNomina registroNomina)
        {
            InitializeComponent();
            vistaNomina = registroNomina;
        }


        private void RegistrarseBtn_Click(object sender, RoutedEventArgs e)
        {
            Empleados empleadoNuevo = new Empleados(nombresTxt.Text, emailTxt.Text, telefonoTxt.Text, ApellidosTxt.Text, fechaNacimientoTxt.Text,
                SexoTxt.Text, cedulaTxt.Text, cargoTxt.Text, int.Parse(inssTxt.Text), Double.Parse(SalarioTxt.Text));

            listaEmpleados.agregarEmpleado(empleadoNuevo);

            vistaNomina.llenarComboBox(listaEmpleados)
;

        }
    }
}
