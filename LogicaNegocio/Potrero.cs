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

        public Potrero(string descripcion, decimal hectareas, int capacidadMaxima)
        {

            _descripcion = descripcion;
            _hectareas = hectareas;
            _capacidadMaxima = capacidadMaxima;
            _id = s_ultid++;

        }
        public decimal Hectareas {
            get { return _hectareas; }
            }
        public decimal CapacidadMaxima
        {
            get { return _capacidadMaxima; }
        }

        public void ValidarDatos()
        {
            if (string.IsNullOrEmpty(_descripcion))
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

            // Verificar existencia
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


    }
}