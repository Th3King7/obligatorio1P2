using LogicaNegocio.Interfaces;
namespace LogicaNegocio
{
    public class Tarea : IValidable
    {
        private int _id;
        private static int s_ultid = 1;
        private string _descripcion;
        private DateTime _fechaInicio;
        private DateTime _fechaCierre;
        private bool _tareaCompletada;
        private string _comentario;

        public Tarea(string descripcion,DateTime fechaInicio,DateTime fechaCierre, bool tareaCompletada,string comentario)
        {
            _descripcion = descripcion;
            _fechaInicio = fechaInicio;
            _fechaCierre = fechaCierre;
            _tareaCompletada = tareaCompletada;
            _comentario = comentario;
            _id = s_ultid++;
        }

        public void ValidarDatos()
        {
        }
    }
}