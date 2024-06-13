using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaNegocio
{
    public class Peon:Empleado,IValidable
    {
        private bool _residenteEstancia;
        private List<Tarea> _tareas = new List<Tarea>();

        public List<Tarea> Tareas
        {
            get { return _tareas; }
        }
        //creamos el metodo constructor
        public   Peon(string email, string password, string nombre, DateTime fechaDeIngreso, bool recidenteEstancia)
            :base(email, password, nombre, fechaDeIngreso)
        { 
            _residenteEstancia = recidenteEstancia;
            precargarTareas();
        }

        public Peon()
            : base("", "", "", DateTime.Now)
        {

        }

        //precargamos tareas
        private void precargarTareas()
        {
            AltaTarea(new Tarea("Limpiar corral de ovejas", new DateTime(2024, 4, 1), new DateTime(2024, 4, 10), true, "Se necesita limpiar el corral antes del próximo parto."));
            AltaTarea(new Tarea("Desparasitar ganado", new DateTime(2024, 4, 2), new DateTime(2024, 4, 12), false, "Es importante desparasitar a tiempo para evitar enfermedades."));
            AltaTarea(new Tarea("Revisar vallado", new DateTime(2024, 4, 3), new DateTime(2024, 4, 15), true, "Algunas partes del vallado están deterioradas y necesitan reparación."));
            AltaTarea(new Tarea("Cosechar maíz", new DateTime(2024, 4, 4), new DateTime(2024, 4, 18), false, "Es hora de cosechar el maíz para alimentar al ganado."));
            AltaTarea(new Tarea("Podar árboles frutales", new DateTime(2024, 4, 5), new DateTime(2024, 4, 20), true, "Las ramas de los árboles frutales necesitan ser podadas para mejorar la producción."));
            AltaTarea(new Tarea("Arreglar bebederos", new DateTime(2024, 4, 6), new DateTime(2024, 4, 22), false, "Varios bebederos están dañados y necesitan reparación."));
            AltaTarea(new Tarea("Sembrar pasto", new DateTime(2024, 4, 7), new DateTime(2024, 4, 25), true, "Es tiempo de sembrar pasto para asegurar el alimento del ganado."));
            AltaTarea(new Tarea("Vacunar terneros", new DateTime(2024, 4, 8), new DateTime(2024, 4, 28), false, "Los terneros necesitan ser vacunados contra diversas enfermedades."));
            AltaTarea(new Tarea("Reparar tejado del granero", new DateTime(2024, 4, 9), new DateTime(2024, 4, 30), true, "El tejado del granero tiene filtraciones y necesita ser reparado."));
            AltaTarea(new Tarea("Fertilizar campos", new DateTime(2024, 4, 10), new DateTime(2024, 5, 1), false, "Es necesario fertilizar los campos para mejorar la calidad del suelo."));
            AltaTarea(new Tarea("Marcar ganado", new DateTime(2024, 4, 11), new DateTime(2024, 5, 3), true, "Se debe marcar al ganado para identificar a cada animal."));
            AltaTarea(new Tarea("Reparar cercado de gallinero", new DateTime(2024, 4, 12), new DateTime(2024, 5, 5), false, "El cercado del gallinero tiene agujeros y necesita ser arreglado."));
            AltaTarea(new Tarea("Poda de árboles en jardín", new DateTime(2024, 4, 13), new DateTime(2024, 5, 7), true, "Los árboles en el jardín necesitan ser podados para mantener su forma."));
            AltaTarea(new Tarea("Revisar sistema de riego", new DateTime(2024, 4, 14), new DateTime(2024, 5, 10), false, "Es importante verificar que el sistema de riego esté funcionando correctamente."));
            AltaTarea(new Tarea("Preparar suelo para siembra", new DateTime(2024, 4, 15), new DateTime(2024, 5, 12), true, "El suelo debe ser preparado adecuadamente antes de la siembra."));
        }

        public void AltaTarea(Tarea nuevaTarea)
        {
            //Validar datos de la tarea 
            nuevaTarea.ValidarDatos();
            //Verificar si no existe en mi lista de tareas una tarea con la mismo valor en su atributo identificatorio
            if (!_tareas.Contains(nuevaTarea))
            {
                //Si no existe una tarea con el mismo valor en su atributo identificatorio, agrego la tarea a la lista
                _tareas.Add(nuevaTarea);
            }
            else
            {
                throw new Exception("Ya existe un peon con el mismo identificador");
            }
        }

        public List<Tarea> ObtenerTareasCompletadas() 
        { 
            List<Tarea> tareasCompletadas = new List<Tarea>();
            foreach (Tarea tarea in _tareas)
            {
                bool tareaCompleta = tarea.TareaCompletada;
                if (!tareaCompleta) 
                {
                    tareasCompletadas.Add(tarea);
                }
            }
            return tareasCompletadas;
        }

        public List<Tarea> TareasOrdenadasPorFechaPactada()
        {
            _tareas.Sort();
            return _tareas;
        }

        public override bool ObtenerUsuario(string unEmail, string unPassword)
        {
            bool peonEncontrado = false;
         if (  unEmail== Email && unPassword == Password)
            {
                peonEncontrado = true;
            }
            return peonEncontrado;
        }

    }
}
