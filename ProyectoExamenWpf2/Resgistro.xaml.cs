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
    /// <summary>
    /// Lógica de interacción para Resgistro.xaml
    /// </summary>
    public partial class Resgistro : Window
    {

        
        ListaUsuarios listaUsuario;

        public Resgistro(ListaUsuarios listaUsuario)
        {
            InitializeComponent();
            this.listaUsuario = listaUsuario;    
        }

        private void UsuarioTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RegistrarseBtn_Click(object sender, RoutedEventArgs e)
        {

            Usuarios usuario = new Usuarios(NombreUsuarioTxt.Text, emailTxt.Text, telefonoTxt.Text, ApellidosTxt.Text, fechaNacimientoTxt.Text, contraseñaTxt.Password);
            
            listaUsuario.agregarUsuario(usuario);
            
            this.Close();
        }
    }
}
