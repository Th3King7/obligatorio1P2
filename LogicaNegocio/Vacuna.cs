using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public class Vacuna : IValidable
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

        public void ValidarDatos()
        {
            if(_nombre.Length < 3)
            {
                throw new Exception("el nombre de la vacuna debe ser mayor que 3 caracteres")

            }
            if (_descripcion.Length < 3)
            {
                throw new Exception("la descripcion de la vacuna debe ser mayor que 3 caracteres")

            }
            if (_proteccionDe.Length < 3)
            {
                throw new Exception("el anticuerpos que brinda la vacuna debe ser mayor que 3 caracteres")

            }
        }
    }
}
