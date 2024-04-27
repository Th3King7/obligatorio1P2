using System.ComponentModel.DataAnnotations;

namespace LogicaNegocio
{
    public abstract class Empleado : IEquatable<Empleado>
    {
        private string _email;
        private string _password;
        private string _nombre;
        private DateTime _fechaDeIngreso;

        public string  Email {
            get { return _email};
                }
        public string Password
        {
            get { return _password};
        }

        public Empleado(string email, string password, string nombre, DateTime fechaDeIngreso)
        {
            _email = email;
            _password = password;
            _nombre = nombre;
            _fechaDeIngreso = fechaDeIngreso;
        }
        public bool Equals(Empleado? other)
        {
            return other.Email == _email && other.Password == _password;
        }
    }
}