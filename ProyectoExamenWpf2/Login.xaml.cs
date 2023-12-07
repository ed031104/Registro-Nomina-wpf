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
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void registrarBtn_Click(object sender, RoutedEventArgs e)
        {
            Resgistro registro = new Resgistro();
            this.Hide();
            registro.ShowDialog();
            this.Show();
        }

        private void iniciarSeccionBtn_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }
    }
}
