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

        public bool Equals(Ganado? other)
        {
            throw new NotImplementedException();
        }

        public void ValidarDatos()
        {
            if (_email.Length > 0)
            {
                throw new Exception("El correo debe ser un correo valido");
            }
            if (_password.Length >= 8)
            {
                throw new Exception("El nombre ser un correo valido");

            }
            if (_nombre.Length > 0)
            {
                throw new Exception("El nombre ser un correo valido");

            }
            if (_fechaDeIngreso < DateTime.Now)
            {
                throw new Exception("La fecha es incorrecta");
            }
        }
    }
}