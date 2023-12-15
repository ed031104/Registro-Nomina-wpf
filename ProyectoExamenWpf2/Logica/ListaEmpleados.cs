using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoExamenWpf2.Logica
{
    public class ListaEmpleados
    {
        List<Empleados> listaEmpleados;
        

        public ListaEmpleados() { 
            this.listaEmpleados = new List<Empleados>();
        }

        public List<Empleados> listaEmpleado { get { return this.listaEmpleados; } }

        public Empleados BuscarEmpleado(String nombreEmpleado) {

            for (int i = 0; i < listaEmpleados.Count; i++) { 

                Empleados empleadoRecorrido = listaEmpleados[i];

                if (empleadoRecorrido != null && empleadoRecorrido.Nombre.Equals(nombreEmpleado)) { 
                        return empleadoRecorrido;
                }
            }
            return null;
        }

        public void agregarEmpleado(Empleados empleado) {

            Empleados empleadoBuscado = BuscarEmpleado(empleado.Nombre);

            if (empleadoBuscado == null)
            {
                listaEmpleados.Add(empleado);
                MessageBox.Show("Se ha agregado el Empleado: "+ empleado.Nombre);
            }
            else {
                MessageBox.Show("El Empleado ya existe");
            }
        }

        public void eliminarEmpleado(Empleados empleado) {
            Empleados empleadoBuscado = BuscarEmpleado(empleado.Nombre);
            if (empleadoBuscado != null)
            {
                listaEmpleados.Remove(empleado);
            }
            else {
                MessageBox.Show("El Empleado no existe");
            }
        }

        public void EditarEmpleado(Empleados empleado) {

            Empleados empleadoBuscado = BuscarEmpleado(empleado.Nombre);
            
            if (empleadoBuscado != null)
            {
                listaEmpleados.Remove(empleadoBuscado);

                empleadoBuscado.Nombre = empleado.Nombre;
                empleadoBuscado.Apellidos = empleado.Apellidos;
                empleadoBuscado.Sexo = empleado.Sexo;
                empleadoBuscado.Email = empleado.Email;
                empleadoBuscado.Telefono = empleado.Telefono;
                empleadoBuscado.SalarioMensual = empleado.SalarioMensual;
                empleadoBuscado.Cargo = empleado.Cargo;
                empleadoBuscado.NumeroCedula = empleado.NumeroCedula;
                empleadoBuscado.FechaNacimiento = empleado.FechaNacimiento;
                empleadoBuscado.NumeroInss = empleado.NumeroInss;

                
                listaEmpleados.Add(empleadoBuscado);

                MessageBox.Show("el Empleado: " +empleadoBuscado.Nombre + "Se ha actualizado con éxito");
            }
            else
            {
                MessageBox.Show("El Empleado no existe");
            }
        }



    }
}
