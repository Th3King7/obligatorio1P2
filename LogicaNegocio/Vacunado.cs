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
    }
}