namespace LogicaNegocio
{
    public class Potrero
    {
        private int _id;
        private static int s_ultid;
        private string _descripcion;
        private decimal _hectareas;
        private int _capacidadMaxima;
        private List<Ganado> _animales = new List<Ganado>();

    }
}