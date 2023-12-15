using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace ProyectoExamenWpf2.Logica
{
    public class Login
    {
        ListaUsuarios lista;
        public Login(ListaUsuarios lista) { 
        
            this.lista = lista;
        }


        public Boolean logearUsuario(String nombre, String contraseña) {
            List<Usuarios> listaUsuario = lista.listaUsuario;

            for (int i = 0; i < listaUsuario.Count; i++)
            {
                Usuarios usuario = listaUsuario[i];

                if (usuario.Nombre.Equals(nombre) && usuario.Contraseña.Equals(contraseña))
                {
                    MessageBox.Show("El usuario " + usuario.Nombre + " se ha logeado.");
                    // Puedes abrir el panel de menú aquí si es necesario
                    // ...

                    return true; // Usuario encontrado y logeado.
                }
            }

            // Si llega a este punto, significa que el usuario no se encontró en la lista.
            MessageBox.Show("El Usuario: " + nombre + " no se ha registrado");
            return false;
        }

    }
}
