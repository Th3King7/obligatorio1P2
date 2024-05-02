using LogicaNegocio.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LogicaNegocio
{
    public abstract class Empleado :IEquatable<Empleado>,IValidable
    {
        private string _email;
        private string _password;
        private string _nombre;
        private DateTime _fechaDeIngreso;

        public string  Email {
            get { return _email; }
        }
        public string Password
        {
            get { return _password; }
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
        public void ValidarDatos()
        {
            if (_email.Length < 0)
            {
                throw new Exception("El correo debe ser un correo valido");
            }
            if (_password.Length < 8)
            {
                throw new Exception("La contraseña debe ser valida");

            }
            if (_nombre.Length < 0)
            {
                throw new Exception("El nombre debe  ser  valido");

            }
            if (_fechaDeIngreso > DateTime.Now)
            {
                throw new Exception("La fecha es incorrecta");
            }
        }
    }
}