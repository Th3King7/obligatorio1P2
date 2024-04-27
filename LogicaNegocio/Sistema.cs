using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    internal class Sistema
    {
        private List<Empleado> _empleados = new List<Empleado>();
        private List<Potrero> _potreros = new List<Potrero>();
        private List<Ganado> _animales = new List<Ganado>();
        private List<Vacuna> _vacunas = new List<Vacuna>();

        public Sistema()
        {
            precargaEmpleados();
        }
        private void precargaEmpleados() {
            AltaPeon(new Peon("elcrack@gmail.com","Rodrigo Romano", 2024/03/25),true);
        }

        public void AltaPeon(Peon peon)
        {

        }
    }
}
