using LogicaNegocio;
using System.Linq.Expressions;
namespace InterfazUsuario
{
    internal class Program
    {
        private static Sistema _miSistema = new Sistema();

        static void Main(string[] args)
        {
            int opcion = -1;
            while (opcion != 0)
            {
                MostrarMenu();
                Console.WriteLine("Ingrese la opcion seleccionada");
                int.TryParse(Console.ReadLine(), out opcion);
                VerificarOpcionSeleccionada(opcion);
            }
        }

            static void MostrarMenu()
            {
                Console.WriteLine("1-Mostrar listado de animales");
                Console.WriteLine("0-Salir");
            }

            static void VerificarOpcionSeleccionada(int opcion)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("hola");
                        //mostrarListadoDeAnimales();
                        break;
                    default:
                        Console.Clear();
                        break;

                }
            }

        static void AgregarPeon()
        {
            try
            {
                //Pedir los datos que necesito para dar de alta un nuevo peon
                Console.WriteLine("Ingrese un email");
                string email = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña");
                string contrasenia = Console.ReadLine();
                Console.WriteLine("Ingrese un nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la fecha de ingreso, formato yyyy-mm-dd");
                DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
                Console.WriteLine("Ingresar S (si reside en la estancia) o N (si no reside)");
                string reside = Console.ReadLine();
                reside.ToUpper();
                bool esResidente = false;
                
                if (reside.Trim() == "S")
                {
                    esResidente = true;
                }
                if (contrasenia.Length >= 8 && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nombre) 
                    && fecha > DateTime.MinValue && !string.IsNullOrEmpty(reside))
                {
                    Peon nuevaPeon = new Peon(email, contrasenia, nombre, fecha, esResidente);
                    _miSistema.AgregarPeon(nuevaPeon);
                    Console.WriteLine("El peon se agrego correctamente");
                }
                else
                {
                    Console.WriteLine("Los datos no  son correctos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            static void AgregarCapataz()
            {
                try
                {
                    //Pedir los datos que necesito para dar de alta un nuevo peon
                    Console.WriteLine("Ingrese un email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Ingrese una contraseña");
                    string contrasenia = Console.ReadLine();
                    Console.WriteLine("Ingrese un nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de ingreso, formato yyyy-mm-dd");
                    DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
                    Console.WriteLine("Ingrese la cantidad de peones a cargo");
                    int.TryParse(Console.ReadLine(), out int cantPeonesCargo)
                    if (contrasenia.Length >= 8 && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nombre)
                        && fecha > DateTime.MinValue && cantPeonesCargo > 0)
                    {
                        Capataz nuevoCapataz = new Capataz(email, contrasenia, nombre, fecha, cantPeonesCargo);
                        _miSistema.AgregarCapataz(nuevoCapataz);
                        Console.WriteLine("El capataz  se agrego correctamente");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no  son correctos");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
    }
        
    
}
    


