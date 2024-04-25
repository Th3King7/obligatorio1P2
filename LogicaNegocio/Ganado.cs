namespace LogicaNegocio
{
    public abstract class Ganado
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
    }
}