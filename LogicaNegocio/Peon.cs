using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Peon:Empleado,IValidable
    {
        private bool _residenteEstancia;
        private List<Tarea> _tareas = new List<Tarea>();

        public Peon(string email, string password, string nombre, DateTime fechaDeIngreso, bool recidenteEstancia)
            :base(email, password, nombre, fechaDeIngreso)
        { 
            _residenteEstancia = recidenteEstancia;
        }
        public void ValidarDatos()
        {
            base.ValidarDatos();
       


        }
    }
}
