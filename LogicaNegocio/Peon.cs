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
            precargarTareas();
        }

                    
        

        //precargamos tareas
        private void precargarTareas()
        {
           /*AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());
            AltaTarea(new Tarea());*/
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
    }
}
