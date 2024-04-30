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

        public Potrero(string descripcion, decimal hectareas,int capacidadMaxima){

            _descripcion = descripcion;
            _hectareas = hectareas;
            _capacidadMaxima = capacidadMaxima;
            _id = s_ultid++;

        }

        public void ValidarDatos()
        { 
        }
        
    }
}