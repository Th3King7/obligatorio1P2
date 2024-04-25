using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Capataz:Empleado
    {
        private Tarea _asignarTarea;

        public Capataz(string email, string password, string nombre, DateTime fechaDeIngreso, Tarea tarea)
            :base(email, password, nombre, fechaDeIngreso)
        {
            _asignarTarea = tarea;
        }
    }

    
}
