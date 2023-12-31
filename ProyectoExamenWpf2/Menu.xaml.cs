﻿using MaterialDesignThemes.Wpf;
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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        
        RegistroNomina registroNomina = new RegistroNomina();

        public Menu()
        {
            InitializeComponent();
        }

        private void EmpleadoBtn_Click(object sender, RoutedEventArgs e)
        {

            RegistroEmpleado registroEmpleado = new RegistroEmpleado(registroNomina);
            miFrame.Navigate(registroEmpleado);
        }

        private void EmpleadoDatosBtn_Click(object sender, RoutedEventArgs e)
        {
            miFrame.Navigate(registroNomina);
        }

        private void NominaBtn_Click(object sender, RoutedEventArgs e)
        {
            Nomina nomina = new Nomina();
            miFrame.Navigate(nomina);
        }
    }
}
