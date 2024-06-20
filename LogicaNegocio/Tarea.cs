using LogicaNegocio.Interfaces;
namespace LogicaNegocio
{
    public class Tarea : IValidable, IComparable<Tarea>
    {
        private int _id;
        private static int s_ultid = 1;
        private string _descripcion;
        private DateTime _fechaInicio;
        private DateTime _fechaCierre;
        private bool _tareaCompletada;
        private string _comentario;

        public int Id
        {
            get { return _id; }
            set {  _id = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }

        }
        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }

        }
        public DateTime FechaCierre
        {
            get { return _fechaCierre; }
            set { _fechaCierre = value; }

        }
        public bool TareaCompletada
        {
            get { return _tareaCompletada; }
            set { _tareaCompletada = value; }

        }
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }

        }

        //creamos el metodo constructor
        public Tarea(string descripcion, DateTime fechaInicio, DateTime fechaCierre, bool tareaCompletada, string comentario)
        {
            _descripcion = descripcion;
            _fechaInicio = fechaInicio;
            _fechaCierre = fechaCierre;
            _tareaCompletada = tareaCompletada;
            _comentario = comentario;
            _id = s_ultid++;
        }
        //validamos que al atributo _descripcion su longitud de caracteres no sea menor a 3 
        //validamos que al atributo _fechaInicio no sea posterior a la actual
        //validamos que al atributo _fechaCierre no sea inferior a _fechaInicio
        //validamos que al atributo _comentario su longitud de caracteres no sea menor a 3
        public void ValidarDatos()
        {
            if (_descripcion.Length < 3)
            {
                throw new Exception("la descripcion debe ser mayor que 3 caracteres ");

            }
            if (_fechaInicio > DateTime.Now && _fechaInicio == DateTime.MinValue)
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
        //ordenamos las tareas
        public int CompareTo(Tarea? other)
        {
            return _fechaCierre.CompareTo(other._fechaCierre);    
        }

    }
}