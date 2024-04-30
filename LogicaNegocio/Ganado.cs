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
            throw new NotImplementedException();
        }

        public void ValidarDatos()
        {


        }

        public override string ToString()
        {
            return "i." + _idCaravana + "/n"
                   "ii." + _raza + "/n"
                   "iii." + _pesoActual + "/n"
                   "iv." + _sexo + "/n";
        }
    }
}