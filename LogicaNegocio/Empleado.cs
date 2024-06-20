using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public abstract class Empleado : IEquatable<Empleado>, IValidable
    {
        private string _email;
        private string _password;
        private string _nombre;
        private DateTime _fechaDeIngreso;
        //creamos las propiedades de _email y _password
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }

        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

        }
        public DateTime FechaDeIngreso
        {
            get { return _fechaDeIngreso; }
            set { _fechaDeIngreso =value ; }
        }
        //creamos el metodo constructor
        public Empleado(string email, string password, string nombre, DateTime fechaDeIngreso)
        {
            _email = email;
            _password = password;
            _nombre = nombre;
            _fechaDeIngreso = fechaDeIngreso;
        }

        //validamos que el email del objeto recibido no sea igual al _email
        public bool Equals(Empleado? other)
        {
            return other.Email == _email && other.Password == _password;
        }
        //validamos que al atributo _email su longitud de caracteres no sea menor a 0 
        //validamos que al atributo _password su longitud de caracteres no sea menor a 8
        //validamos que al atributo _nombre su longitud de caracteres no sea menor a 0 
        //validamos que al atributo _fechaDeIngreso no sea posterior a la actual

        //Declaramos metodo abstracto
        public abstract bool ObtenerUsuario(string unEmail,string unPassword);

        public void ValidarDatos()
        {
            if (_email.Length < 8)
            {
                throw new Exception("El correo debe ser un correo valido");
            }
            if (_password.Length < 8)
            {
                throw new Exception("La contraseña debe ser valida");

            }
            if (_nombre.Length < 3)
            {
                throw new Exception("El nombre debe  ser  valido");

            }
            if (_fechaDeIngreso > DateTime.Now && _fechaDeIngreso == DateTime.MinValue)
            {
                throw new Exception("La fecha es incorrecta");
            }
        }
    }
}