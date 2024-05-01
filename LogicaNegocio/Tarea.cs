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

        public Tarea(string descripcion, DateTime fechaInicio, DateTime fechaCierre, bool tareaCompletada, string comentario)
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
            if (_descripcion.Length < 3)
            {
                throw new Exception("la descripcion debe ser mayor que 3 caracteres ");

            }
            if (_fechaInicio < DateTime.Now)
            {
                throw new Exception("la fecha de inicio debe menor a la de la actualidad");

            }
            if (_fechaCierre < _fechaInicio)
            {
                throw new Exception("la fecha de cierre no puede ser  menor a la de la fecha de inicio");

            }
            if (_comentario.Length < 3)
            {
                throw new Exception("el comentario debe ser mayor que 3 caracteres ");

            }

        }
    }
}