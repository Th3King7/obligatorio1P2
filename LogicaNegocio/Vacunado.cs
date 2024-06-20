using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public class Vacunado : IValidable
    {
        private Vacuna _tipoVacuna;
        private DateTime _fechaDeVacunacion;
        private DateTime _fechaDeVencimiento;
        //creamos el metodo constructor
        public Vacunado(Vacuna tipoVacuna, DateTime fechaDeVacunacion, DateTime fechaDeVencimiento)
        {
            _tipoVacuna = tipoVacuna;
            _fechaDeVacunacion = fechaDeVacunacion;
            _fechaDeVencimiento = fechaDeVencimiento;
        }
        public Vacunado()
        {

        }
        public Vacuna TipoVacuna
        {
            get { return _tipoVacuna; }
            set { _tipoVacuna = value; }
        }
        public DateTime FechaDeVacunacion
        {
            get { return _fechaDeVacunacion; }
            set { _fechaDeVacunacion = value; }
        }
        public DateTime FechaDeVencimiento
        {
            get { return _fechaDeVencimiento; }
            set { _fechaDeVencimiento = value; }
        }
        //validamos que al atributo _fechaDeVacunacion no sea posterior a la actual
        //validamos que al atributo _fechaDeVencimiento no sea inferior a _fechaDeVacunacion
        public void ValidarDatos()
        {
            if (_fechaDeVacunacion > DateTime.Now && _fechaDeVacunacion!= DateTime.MinValue)
            {
                throw new Exception("La fecha de vacunación no puede ser posterior a la fecha actual.");
            }

            // Calculamos la fecha de vencimiento esperada (1 año después de la vacunación)
            DateTime fechaVencimientoEsperada = _fechaDeVacunacion.AddYears(1);

            if (_fechaDeVencimiento < fechaVencimientoEsperada)
            {
                throw new Exception("La fecha de vencimiento no puede ser menor a 1 año después de la fecha de vacunación.");
            }
        }

    }
}