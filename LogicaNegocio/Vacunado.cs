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
        //validamos que al atributo _fechaDeVacunacion no sea posterior a la actual
        //validamos que al atributo _fechaDeVencimiento no sea inferior a _fechaDeVacunacion
        public void ValidarDatos()
        {
            if (_fechaDeVacunacion > DateTime.Now)
            {
                throw new Exception("La fecha de vacunacion no puede ser mayor actual.");
            }
            if (_fechaDeVencimiento < _fechaDeVacunacion)
            {
                throw new Exception("La fecha de vencimiento no puede ser menor a la de vacunacion.");
            }
        }
    }
}