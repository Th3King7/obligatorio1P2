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
        private int _peonesACargo;

        public Capataz(string email, string password, string nombre, DateTime fechaDeIngreso , int cantPeonesCargo)
            :base(email, password, nombre, fechaDeIngreso)
        {
            _peonesACargo = cantPeonesCargo;
        }
    }

    
}
