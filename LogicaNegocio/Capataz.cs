using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Capataz : Empleado, IValidable
    {
        private Tarea _asignarTarea;
        private int _peonesACargo;
        //creamos el metodo constructor
        public Capataz(string email, string password, string nombre, DateTime fechaDeIngreso, int cantPeonesCargo)
            : base(email, password, nombre, fechaDeIngreso)
        {
            _peonesACargo = cantPeonesCargo;

        }
        public Capataz() : base("", "", "", DateTime.Now)
        {
            // Inicializa el peón con valores predeterminados si es necesario
        }
        //validamos que al atributo _peonesACargo no sea menor a 0 
        public void ValidarDatos()
        {
            base.ValidarDatos();
                if (_peonesACargo < 0) {

                    throw new Exception("No puede no tener peones a cargo");
 
                }            

        }
    }
    
}
