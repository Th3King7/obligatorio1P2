using LogicaNegocio.Interfaces;
namespace LogicaNegocio
{
    public class Potrero : IValidable
    {
        private int _id;
        private static int s_ultid = 1;
        private string _descripcion;
        private decimal _hectareas;
        private int _capacidadMaxima;
        private List<Ganado> _animales = new List<Ganado>();
        //creamos el metodo constructor
        public Potrero(string descripcion, decimal hectareas, int capacidadMaxima)
        {
            _descripcion = descripcion;
            _hectareas = hectareas;
            _capacidadMaxima = capacidadMaxima;
            _id = s_ultid++;
        }
        //creamos las propiedades de _hectareas y _capacidadMaxima
        public decimal Hectareas {
            get { return _hectareas; }
            }
        public int CapacidadMaxima
        {
            get { return _capacidadMaxima; }
        }
        public int Id
        {
            get { return _id; }
        }
        public string Descripcion
        {
            get { return _descripcion;}
        }
        public List<Ganado> Animales
        {
            get { return _animales; }
        }

        //validamos que al atributo _descripcion su longitud de caracteres no sea menor a 0 
        //validamos que al atributo _hectareas no sea menor a 0 
        //validamos que al atributo _capacidadMaxima no sea menor a 0 


        public void ValidarDatos()
        {
            if (_descripcion.Length < 0)
            {
                throw new Exception("La descripción no puede estar vacía.");
            }

            if (_hectareas <= 0)
            {
                throw new Exception("Las hectáreas deben ser mayores a 0.");
            }

            if (_capacidadMaxima <= 0)
            {
                throw new Exception("La capacidad máxima debe ser mayor a 0.");
            }
        }

        public void AgregarGanado(Ganado nuevoGanado)
        {
            // Validar datos del ganado
            nuevoGanado.ValidarDatos();

            if (!Sistema.Instancia.AnimalLibre(nuevoGanado.IdCaravana))
            {
                throw new Exception("El animal no es libre ya está asignado a un potrero.");
            }

            // Verificar espacio en el potrero
            if (_animales.Count < _capacidadMaxima)
            {
                if (!_animales.Contains(nuevoGanado))
                {
                    // Agregarlo a la lista 
                    _animales.Add(nuevoGanado);
                }
                else
                {
                    throw new Exception("El ganado ya existe en el potrero.");
                }
            }
            else
            {
                throw new Exception("No hay espacio suficiente en el potrero para más ganado.");
            }
        }

        //modificamos el metodo ToString de Object para que muestre lo siguiente
        public override string ToString()
        {
            return $"ID: {_id}, Descripcion: {_descripcion}, Hectareas: {_hectareas}, Capacidad Maxima: {_capacidadMaxima}";
        }

        public int CompareTo(Potrero? other)
        {
            int comparacion = _capacidadMaxima.CompareTo(other._capacidadMaxima);
            if (comparacion == 0)
            {
                comparacion = _animales.Count.CompareTo(other._animales.Count) -1;
            }
            return comparacion;
        }
    }
}