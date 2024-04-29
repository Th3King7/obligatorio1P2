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
            AltaPeon(new Peon("elcrack@gmail.com", "contRodr1", "Rodrigo Romano", new DateTime(2024, 3, 25), true));
            AltaPeon(new Peon("pepe@gmail.com", "pepe1234", "José Pérez", new DateTime(2024, 4, 12), false));
            AltaPeon(new Peon("juanito@gmail.com", "juanito567", "Juan Pérez", new DateTime(2024, 5, 3), true));
            AltaPeon(new Peon("laura@gmail.com", "lauraPass", "Laura López", new DateTime(2024, 6, 18), false));
            AltaPeon(new Peon("ana@gmail.com", "ana2024", "Ana Martínez", new DateTime(2024, 7, 7), true));
            AltaPeon(new Peon("pepito@gmail.com", "pepito987", "José González", new DateTime(2024, 8, 29), false));
            AltaPeon(new Peon("maria@gmail.com", "mariaPass", "María Rodríguez", new DateTime(2024, 9, 14), true));
            AltaPeon(new Peon("pedrito@gmail.com", "pedrito456", "Pedro Sánchez", new DateTime(2024, 10, 8), false));
            AltaPeon(new Peon("luis@gmail.com", "luisPass", "Luis García", new DateTime(2024, 11, 21), true));
            AltaPeon(new Peon("pepa@gmail.com", "pepa2024", "Josefa Martínez", new DateTime(2024, 12, 30), false));
        }

        public void AltaPeon(Peon peon)
        {

        }

        public void AgregarPeon(Peon nuevoPeon)
        {
            //Validar datos de la nueva especialidad
            nuevoPeon.ValidarDatos();
            //Verificar si no existe en mi lista de empleados un peon con la mismo valor en su atributo identificatorio
            if (!_empleados.Contains(nuevoPeon))
            {
                //Si no existe un peon con el mismo valor en su atributo identificatorio, agrego el peon a la lista
                _empleados.Add(nuevoPeon);
            }
            else
            {
                throw new Exception("Ya existe un peon con el mismo identificador");
            }
        }

        public void AgregarCapataz(Capataz nuevoCapataz)
        {
            //Validar datos de la nueva especialidad
            nuevoCapataz.ValidarDatos();
            //Verificar si no existe en mi lista de empleados un capataz con la mismo valor en su atributo identificatorio
            if (!_empleados.Contains(nuevoCapataz))
            {
                //Si no existe una capataz con el mismo valor en su atributo identificatorio, agrego el capataz a la lista
                _empleados.Add(nuevoCapataz);
            }
            else
            {
                throw new Exception("Ya existe un capataz con el mismo identificador");
            }
        }

        public void AgregarOvino(Ovino nuevoOvino)
        {
            //Validar datos de la nueva especialidad
            nuevoOvino.ValidarDatos();
            //Verificar si no existe en mi lista de empleados un capataz con la mismo valor en su atributo identificatorio
            if (!_animales.Contains(nuevoOvino))
            {
                //Si no existe una capataz con el mismo valor en su atributo identificatorio, agrego el capataz a la lista
                _animales.Add(nuevoOvino);
            }
            else
            {
                throw new Exception("Ya existe un capataz con el mismo identificador");
            }
        }

    }
}
