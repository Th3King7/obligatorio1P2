using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Sistema 
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
            AltaPeon (new Peon("elcrack@gmail.com", "Rodrigo Romano", new DateTime(2024, 3, 25)), true);
            AltaPeon (new Peon("pepe@gmail.com", "José Pérez", new DateTime(2024, 4, 12)), false);
            AltaPeon (new Peon("juanito@gmail.com", "Juan Pérez", new DateTime(2024, 5, 3)), true);
            AltaPeon (new Peon("laura@gmail.com", "Laura López", new DateTime(2024, 6, 18)), false);
            AltaPeon (new Peon("ana@gmail.com", "Ana Martínez", new DateTime(2024, 7, 7)), true);
            AltaPeon (new Peon("pepito@gmail.com", "José González", new DateTime(2024, 8, 29)), false);
            AltaPeon (new Peon("maria@gmail.com", "María Rodríguez", new DateTime(2024, 9, 14)), true);
            AltaPeon (new Peon("pedrito@gmail.com", "Pedro Sánchez", new DateTime(2024, 10, 8)), false);
            AltaPeon (new Peon("luis@gmail.com", "Luis García", new DateTime(2024, 11, 21)), true);
            AltaPeon (new Peon("pepa@gmail.com", "Josefa Martínez", new DateTime(2024, 12, 30)), false);
        }

        public void AltaPeon(Peon peon)
        {

        }
    }
}
