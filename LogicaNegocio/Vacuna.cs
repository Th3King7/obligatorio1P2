namespace LogicaNegocio
{
    public class Vacuna
    {
        private string _nombre;
        private string _descripcion;
        private string _proteccionDe;

        public Vacuna(string nombre,string descripcion,string proteccionDe)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _proteccionDe = proteccionDe;
        }
    }
}