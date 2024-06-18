using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public class Bovino : Ganado, IValidable
    {
        private string _tipoAlimentacion;
        private static decimal s_precioKgBovino;
        //creamos el metodo constructor
        public Bovino(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido, string tipoAlimentacion)
            : base(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, hibrido)
        {
            _tipoAlimentacion = tipoAlimentacion;
        }
        public Bovino() :
base("", "", "", DateTime.Now, 0, 0, 0, false)
        {
        }
        //validamos que al atributo _tipoAlimentacion sea Grano o Pasto
        public void ValidarDatos()
        {
            base.ValidarDatos();
            if (_tipoAlimentacion != "Granos" && _tipoAlimentacion != "Pasto")
            {
                throw new Exception("la alimentacion del bovino debe ser en Pasto o Granos ");

            }
        }
        public override bool ObtenerAnimal(string idAnimal)
        {
            bool bovinoEnconrado = false;
            if (idAnimal == IdCaravana)
            {
                bovinoEnconrado = true;
            }
            return bovinoEnconrado;
        }

        
      


    }
}
