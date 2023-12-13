using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoExamenWpf2.Logica
{
    public class ListaUsuarios
    {
        private List<Usuarios> listaUsuarios;

        public ListaUsuarios()
        {
            listaUsuarios = new List<Usuarios>();
        }


        public Usuarios BuscarUsuario(String nombre) {

            for (int i = 0; i < listaUsuarios.Count; i++) {

                Usuarios user = listaUsuarios[i];

                if (user != null && user.Nombre.Equals(nombre)) { 
                    return user;
                }

            }
            return null;
        }

        public void agregarUsuario(Usuarios usuario) {


            Usuarios usuarioRecorridos = BuscarUsuario(usuario.Nombre);

            if (usuarioRecorridos == null)
            {
                listaUsuarios.Add(usuario);
                MessageBox.Show("El usuario '" + usuario.Contraseña + "' se ha registrado correctamente.");

            }
            else {
                MessageBox.Show("El usuario ya existe, sapo triple ijue***");
            }
        }

        public List<Usuarios> listaUsuario { get { return listaUsuarios; } set { listaUsuarios = value; } }

    }
}
