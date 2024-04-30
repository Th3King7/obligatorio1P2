using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public abstract class Ganado :IEquatable<Ganado>, IValidable
    {
        private string _idCaravana;
        private string _sexo;
        private string _raza;
        private DateTime _fechaNacimiento;
        private decimal _precioCompra;
        private decimal _costoAlimentacion;
        private decimal _pesoActual;
        private bool _hibrido;
        private List<Vacunado> _vacunasDadas = new List<Vacunado>();

        public string IdCaravana
        {
            get { return _idCaravana; }
        }

        public Ganado(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido)
        {
            _idCaravana = idCaravana;
            _sexo = sexo;
            _raza = raza;
            _fechaNacimiento = fechaNacimiento;
            _precioCompra = precioCompra;
            _costoAlimentacion = costoAlimentacion;
            _pesoActual = pesoActual;
            _hibrido = hibrido;
        }
 
        public void AltaVacunado(Vacunado nuevaVacunacion)
        {
            //Validar datos de la nueva vacunacion
            //nuevaVacunacion.ValidarDatos();
            //Verificar si no existe en mi lista de vacunado la vacuna ya dada  con el mismo valor en su atributo identificatorio
            if (!_vacunasDadas.Contains(nuevaVacunacion))
            {
                //Si no existe una vacuna dada con el mismo valor en su atributo identificatorio, agrego el bovino a la lista
                _vacunasDadas.Add(nuevaVacunacion);
            }
            else
            {
                throw new Exception("Ya se le dio la vacuna al animal");
            }
        }

        public bool Equals(Ganado? other)
        {
            return other.IdCaravana == _idCaravana;
        }


        public void ValidarDatos()
        {
            if(_idCaravana.Length != 8)
            {
               throw new Exception ("el id debe ser en formato alfanumerico de 8 digitos")
            }
            if( _sexo!="Macho" || _sexo != "Hembra")
            {
                throw new Exception("el sexo debe ser en Macho o Hembra ")

            }
            if (_raza != "Merino" || _raza != "Angus" || _raza != "Hereford")
            {
                throw new Exception("la raza debe ser: Merino, Angus , Hereford ")

            }
            if (_fechaNacimiento < DateTime.Now)
            {
                throw new Exception("La fecha es incorrecta");
            }
            if(_precioCompra < 0)
            {
                throw new Exception("El precio de compra del animal tiene que ser mayor a 0");

            }
            if (_costoAlimentacion < 0)
            {
                throw new Exception("El costo de alimetacion del animal tiene que ser mayor a 0");

            }
            if (_pesoActual < 0)
            {
                throw new Exception("El peso actual del animal tiene que ser mayor a 0");

            }


        }

        public override string ToString()
        {
            return "i." + _idCaravana + "\n" +
                   "ii." + _raza + "\n" +
                   "iii." + _pesoActual + "\n" +
                   "iv." + _sexo + "\n";
        }
    }
}