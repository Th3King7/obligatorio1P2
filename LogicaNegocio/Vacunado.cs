namespace LogicaNegocio
{
    public class Vacunado
    {
        private Vacuna _tipoVacuna;
        private DateTime _fechaDeVacunacion;
        private DateTime _fechaDeVencimiento;

        public Vacunado(Vacuna tipoVacuna, DateTime fechaDeVacunacion, DateTime fechaDeVencimiento)
        {
            _tipoVacuna = tipoVacuna;
            _fechaDeVacunacion = fechaDeVacunacion;
            _fechaDeVencimiento = fechaDeVencimiento;
        }

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