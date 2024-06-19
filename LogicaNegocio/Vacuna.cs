using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public class Vacuna : IValidable
    {
        private string _nombre;
        private string _descripcion;
        private string _proteccionDe;
        //creamos el metodo constructor
        public Vacuna(string nombre,string descripcion,string proteccionDe)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _proteccionDe = proteccionDe;
        }
        public Vacuna()
        {
            
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
         public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public string Proteccion
        {
            get { return _proteccionDe; }
            set { _proteccionDe = value; }
        }
        //validamos que al atributo _nombre su longitud de caracteres no sea menor a 3 
        //validamos que al atributo _descripcion su longitud de caracteres no sea menor a 3
        //validamos que al atributo _proteccionDe su longitud de caracteres no sea menor a 3

        public void ValidarDatos()
        {
            if(_nombre.Length < 3)
            {
                throw new Exception("el nombre de la vacuna debe ser mayor que 3 caracteres");

            }
            if (_descripcion.Length < 3)
            {
                throw new Exception("la descripcion de la vacuna debe ser mayor que 3 caracteres");

            }
            if (_proteccionDe.Length < 3)
            {
                throw new Exception("el anticuerpos que brinda la vacuna debe ser mayor que 3 caracteres");

            }
        }
    }
}
