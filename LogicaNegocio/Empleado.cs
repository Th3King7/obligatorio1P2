namespace LogicaNegocio
{
    public abstract class Empleado
    {
        private string _email;
        private string _password;
        private string _nombre;
        private DateTime _fechaDeIngreso;

        public Empleado(string email, string password, string nombre, DateTime fechaDeIngreso)
        {
            _email = email;
            _password = password;
            _nombre = nombre;
            _fechaDeIngreso = fechaDeIngreso;
        }
    }
}