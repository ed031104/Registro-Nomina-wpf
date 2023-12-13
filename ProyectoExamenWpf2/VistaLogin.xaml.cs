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
    public partial class MainWindow : Window
    {

        ListaUsuarios listaUsuarios;
        public MainWindow()
        {
            InitializeComponent();
            listaUsuarios = new ListaUsuarios();
        }
        
        public ListaUsuarios ListaUsuarios { get { return listaUsuarios;} }

        private void Grid_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void registrarBtn_Click(object sender, RoutedEventArgs e)
        {
            Resgistro registro = new Resgistro(listaUsuarios);
            this.Hide();
            registro.ShowDialog();
            this.Show();
        }

        private void iniciarSeccionBtn_Click(object sender, RoutedEventArgs e)
        {
            String nombreUser = UsuarioTxt.Text;

            Login loguearUser = new Login(listaUsuarios);

            if (loguearUser.logearUsuario(nombreUser) == true)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }

            
            
        }
    }
}
