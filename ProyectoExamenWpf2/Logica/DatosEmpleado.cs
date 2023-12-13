using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamenWpf2.Logica
{
    public class DatosEmpleado
    {
        Empleados empleado;
        int HorasLaboradas, añosAntiguedad;
        double incentivo, comision;

        public DatosEmpleado(Empleados empleado, int HorasLaboradas, int añosAntiguedad, double incentivo, double comision) { 
            this.empleado = empleado;
            this.HorasLaboradas = HorasLaboradas;
            this.añosAntiguedad = añosAntiguedad;
            this.incentivo = incentivo;
            this.comision = comision;
        }
        
        public Empleados Empleado { get { return empleado; } set { empleado = value; } }
        
        public int HorasLaborada { get { return HorasLaboradas; } set { HorasLaboradas = value; } }
        
        public int AñosAntiguedad { get { return añosAntiguedad; } set { añosAntiguedad = value; } }
        
        public double Incentivo { get { return incentivo; } set { incentivo= value; } }
        
        public double Comision { get { return comision; } set { comision= value; } }

    }
}
