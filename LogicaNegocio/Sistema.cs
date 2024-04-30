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

        public List<Ganado> Animales
        {
            get { return _animales; }
        }

        public Sistema()
        {
            precargaEmpleados();
            precargaAnimales();
            precargaPotreros();
            precargaVacunas();

        }
        private void precargaEmpleados()
        {
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
            AltaCapataz(new Capataz("pepguardiola@gmail.com", "pepguardiola2024", "Jose Martínez", new DateTime(2024, 8, 30), 6));
            AltaCapataz(new Capataz("bayerLeverkusen@gmail.com", "pLuis2024", "Luis Sanchez", new DateTime(2024, 26, 30), 4));
        }

        private void precargaAnimales()
        {
            // Bovinos
            new Bovino("B0000001", "Macho", "Angus", new DateTime(2019, 5, 10), 1200, 250, 400, false, "Pasto"),
            new Bovino("B0000002", "Hembra", "Hereford", new DateTime(2020, 8, 15), 1000, 200, 350, false, "Pasto"),
            new Bovino("B0000003", "Macho", "Angus", new DateTime(2018, 12, 20), 1400, 300, 450, true, "Granos"),
            new Bovino("B0000004", "Hembra", "Hereford", new DateTime(2021, 4, 5), 1100, 220, 370, false, "Pasto"),
            new Bovino("B0000005", "Macho", "Angus", new DateTime(2020, 7, 12), 1300, 270, 420, true, "Granos"),
            new Bovino("B0000006", "Macho", "Angus", new DateTime(2019, 8, 23), 1150, 240, 380, false, "Pasto"),
            new Bovino("B0000007", "Hembra", "Hereford", new DateTime(2021, 2, 14), 1050, 210, 360, false, "Pasto"),
            new Bovino("B0000008", "Macho", "Angus", new DateTime(2020, 10, 30), 1250, 260, 430, true, "Granos"),
            new Bovino("B0000009", "Hembra", "Hereford", new DateTime(2019, 6, 8), 1150, 240, 380, false, "Pasto"),
            new Bovino("B0000010", "Macho", "Angus", new DateTime(2021, 1, 17), 1350, 280, 440, true, "Granos"),
            new Bovino("B0000011", "Macho", "Angus", new DateTime(2018, 11, 28), 1100, 230, 370, false, "Pasto"),
            new Bovino("B0000012", "Hembra", "Hereford", new DateTime(2019, 9, 9), 1200, 250, 400, false, "Pasto"),
            new Bovino("B0000013", "Macho", "Angus", new DateTime(2020, 5, 7), 1300, 270, 420, true, "Granos"),
            new Bovino("B0000014", "Hembra", "Hereford", new DateTime(2021, 3, 26), 1150, 240, 380, false, "Pasto"),
            new Bovino("B0000015", "Macho", "Angus", new DateTime(2019, 7, 18), 1350, 280, 440, true, "Granos"),
            new Bovino("B0000016", "Macho", "Angus", new DateTime(2018, 10, 12), 1200, 250, 400, false, "Pasto"),
            new Bovino("B0000017", "Hembra", "Hereford", new DateTime(2020, 4, 4), 1100, 230, 370, false, "Pasto"),
            new Bovino("B0000018", "Macho", "Angus", new DateTime(2019, 12, 21), 1300, 270, 420, true, "Granos"),
            new Bovino("B0000019", "Hembra", "Hereford", new DateTime(2021, 8, 30), 1150, 240, 380, false, "Pasto"),
            new Bovino("B0000020", "Macho", "Angus", new DateTime(2020, 2, 9), 1350, 280, 440, true, "Granos"),
            new Bovino("B0000021", "Macho", "Angus", new DateTime(2018, 6, 29), 1200, 250, 400, false, "Pasto"),
            new Bovino("B0000022", "Hembra", "Hereford", new DateTime(2019, 10, 3), 1100, 230, 370, false, "Pasto"),
            new Bovino("B0000023", "Macho", "Angus", new DateTime(2020, 3, 15), 1300, 270, 420, true, "Granos"),
            new Bovino("B0000024", "Hembra", "Hereford", new DateTime(2021, 7, 25), 1150, 240, 380, false, "Pasto"),
            new Bovino("B0000025", "Macho", "Angus", new DateTime(2019, 11, 11), 1350, 280, 440, true, "Granos"),
            new Bovino("B0000026", "Macho", "Angus", new DateTime(2018, 4, 27), 1200, 250, 400, false, "Pasto"),
            new Bovino("B0000027", "Hembra", "Hereford", new DateTime(2020, 11, 6), 1100, 230, 370, false, "Pasto"),
            new Bovino("B0000028", "Macho", "Angus", new DateTime(2019, 1, 8), 1300, 270, 420, true, "Granos"),
            new Bovino("B0000029", "Hembra", "Hereford", new DateTime(2021, 5, 20), 1150, 240, 380, false, "Pasto"),
            new Bovino("B0000030", "Macho", "Angus", new DateTime(2020, 9, 2), 1350, 280, 440, true, "Granos"),
            // Ovinos
            new Ovino("O0000001", "Macho", "Merino", new DateTime(2019, 3, 5), 500, 100, 50, false),
            new Ovino("O0000002", "Hembra", "Merino", new DateTime(2019, 6, 12), 550, 110, 55, false),
            new Ovino("O0000003", "Macho", "Merino", new DateTime(2020, 1, 20), 600, 120, 60, true),
            new Ovino("O0000004", "Hembra", "Merino", new DateTime(2021, 9, 18), 530, 105, 52, false),
            new Ovino("O0000005", "Macho", "Merino", new DateTime(2020, 12, 3), 570, 115, 57, true),
            new Ovino("O0000006", "Macho", "Merino", new DateTime(2019, 5, 15), 510, 102, 51, false),
            new Ovino("O0000007", "Hembra", "Merino", new DateTime(2019, 8, 22), 560, 112, 56, false),
            new Ovino("O0000008", "Macho", "Merino", new DateTime(2020, 3, 10), 610, 122, 61, true),
            new Ovino("O0000009", "Hembra", "Merino", new DateTime(2021, 10, 2), 540, 108, 54, false),
            new Ovino("O0000010", "Macho", "Merino", new DateTime(2020, 1, 5), 580, 116, 58, true),
            new Ovino("O0000011", "Macho", "Merino", new DateTime(2019, 6, 20), 520, 104, 52, false),
            new Ovino("O0000012", "Hembra", "Merino", new DateTime(2019, 9, 28), 570, 114, 57, false),
            new Ovino("O0000013", "Macho", "Merino", new DateTime(2020, 4, 15), 620, 124, 62, true),
            new Ovino("O0000014", "Hembra", "Merino", new DateTime(2021, 11, 9), 550, 110, 55, false),
            new Ovino("O0000015", "Macho", "Merino", new DateTime(2020, 2, 25), 590, 118, 59, true),
            new Ovino("O0000016", "Macho", "Merino", new DateTime(2019, 7, 10), 530, 106, 53, false),
            new Ovino("O0000017", "Hembra", "Merino", new DateTime(2019, 10, 18), 580, 116, 58, false),
            new Ovino("O0000018", "Macho", "Merino", new DateTime(2020, 5, 5), 630, 126, 63, true),
            new Ovino("O0000019", "Hembra", "Merino", new DateTime(2021, 12, 1), 560, 112, 56, false),
            new Ovino("O0000020", "Macho", "Merino", new DateTime(2020, 3, 20), 600, 120, 60, true),
            new Ovino("O0000021", "Macho", "Merino", new DateTime(2019, 8, 5), 540, 108, 54, false),
            new Ovino("O0000022", "Hembra", "Merino", new DateTime(2019, 11, 12), 590, 118, 59, false),
            new Ovino("O0000023", "Macho", "Merino", new DateTime(2020, 6, 30), 640, 128, 64, true),
            new Ovino("O0000024", "Hembra", "Merino", new DateTime(2022, 1, 15), 570, 114, 57, false),
            new Ovino("O0000025", "Macho", "Merino", new DateTime(2020, 4, 10), 610, 122, 61, true),
            new Ovino("O0000026", "Macho", "Merino", new DateTime(2019, 9, 25), 550, 110, 55, false),
            new Ovino("O0000027", "Hembra", "Merino", new DateTime(2019, 12, 3), 600, 120, 60, false),
            new Ovino("O0000028", "Macho", "Merino", new DateTime(2020, 7, 20), 650, 130, 65, true),
            new Ovino("O0000029", "Hembra", "Merino", new DateTime(2022, 2, 5), 580, 116, 58, false),
            new Ovino("O0000030", "Macho", "Merino", new DateTime(2020, 3, 15), 620, 124, 62, true),

        }

        private void precargaPotreros()
        {
            /*
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());
            AltaPotrero(new Potrero());*/
        }
        private void precargaVacunas()
        {
            /*
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());
            AltaVacuna(new Vacuna());*/
        }



        public void AltaPeon(Peon nuevoPeon)
        {
            //Validar datos de el nuevo peon
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

        public void AltaCapataz(Capataz nuevoCapataz)
        {
            //Validar datos de el nuevo capataz
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

        public void AltaOvino(Ovino nuevoOvino)
        {
            //Validar datos de el nuevo ovino
            nuevoOvino.ValidarDatos();
            //Verificar si no existe en mi lista de animales el ovino con la mismo valor en su atributo identificatorio
            if (!_animales.Contains(nuevoOvino))
            {
                //Si no existe una ovino con el mismo valor en su atributo identificatorio, agrego el ovino a la lista
                _animales.Add(nuevoOvino);
            }
            else
            {
                throw new Exception("Ya existe un ovino con el mismo identificador");
            }
        }
        public void AltaBovino(Bovino nuevoBovino)
        {
            //Validar datos de el nuevo bovino
            nuevoBovino.ValidarDatos();
            //Verificar si no existe en mi lista de animales el bovino con el mismo valor en su atributo identificatorio
            if (!_animales.Contains(nuevoBovino))
            {
                //Si no existe una bovino con el mismo valor en su atributo identificatorio, agrego el bovino a la lista
                _animales.Add(nuevoBovino);
            }
            else
            {
                throw new Exception("Ya existe un bovino con el mismo identificador");
            }

        }
        public void AltaPotrero(Potrero nuevoPotrero)
        {
            //Validar datos de el nuevo potrero
            nuevoPotrero.ValidarDatos();
            //Verificar si no existe en mi lista de potreros el potrero con el mismo valor en su atributo identificatorio
            if (!_potreros.Contains(nuevoPotrero))
            {
                //Si no existe una potrero con el mismo valor en su atributo identificatorio, agrego el bovino a la lista
                _potreros.Add(nuevoPotrero);
            }
            else
            {
                throw new Exception("Ya existe un potrero con el mismo identificador");
            }

        }
        public void AltaVacuna(Vacuna nuevaVacuna)
        {
            //Validar datos de el nueva vacuna
            nuevaVacuna.ValidarDatos();
            //Verificar si no existe en mi lista de vacunas la vacuna con el mismo valor en su atributo identificatorio
            if (!_vacunas.Contains(nuevaVacuna))
            {
                //Si no existe una vacuna con el mismo valor en su atributo identificatorio, agrego el bovino a la lista
                _vacunas.Add(nuevaVacuna);
            }
            else
            {
                throw new Exception("Ya existe una vacuna con el mismo identificador");
            }
        }
    }
}
