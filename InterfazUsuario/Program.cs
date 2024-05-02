using LogicaNegocio;
using System.Linq.Expressions;
namespace InterfazUsuario
{
    namespace InterfazUsuario
    {
        internal class Program
        {
            //se declara un acceso a la clase sistema
            private static Sistema _miSistema = new Sistema();

            static void Main(string[] args)
            {
                //opciones para salir de consola
                int opcion = -1;
                while (opcion != 0)
                {
                    //mostramos menu
                    MostrarMenu();
                    Console.WriteLine("Ingrese la opcion seleccionada");
                    int.TryParse(Console.ReadLine(), out opcion);
                    VerificarOpcionSeleccionada(opcion);
                }
            }

            //creaamos el menu con sus opciones
            static void MostrarMenu()
            {
                Console.WriteLine("1-Mostrar listado de animales");
                Console.WriteLine("2-Agregar bovino");
                Console.WriteLine("3-Mostrar potreros con area y capacidad");
                Console.WriteLine("4-Establecer precio lana ovinos");
                Console.WriteLine("0-Salir");
            }

            //verificamos la opcion que selecciona el usuario
            static void VerificarOpcionSeleccionada(int opcion)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarListadoDeAnimales();
                        break;
                    case 2:
                        AgregarBovino();
                        break;
                    case 3:
                        MostrarPotrerosConAreaYCapacidad();
                        break;
                    case 4:
                        EstablecerPrecioLanaOvinos();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }

            //alta de nuevo peon
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
                        _miSistema.AltaPeon(nuevaPeon);
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
            }

            //alta de nuevo capataz
            static void AgregarCapataz()
            {
                try
                {
                    //Pedir los datos que necesito para dar de alta un nuevo capataz
                    Console.WriteLine("Ingrese un email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Ingrese una contraseña");
                    string contrasenia = Console.ReadLine();
                    Console.WriteLine("Ingrese un nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de ingreso, formato yyyy-mm-dd");
                    DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
                    Console.WriteLine("Ingrese la cantidad de peones a cargo");
                    int.TryParse(Console.ReadLine(), out int cantPeonesCargo);
                    if (contrasenia.Length >= 8 && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nombre)
                        && fecha > DateTime.MinValue && cantPeonesCargo > 1)
                    {
                        Capataz nuevoCapataz = new Capataz(email, contrasenia, nombre, fecha, cantPeonesCargo);
                        _miSistema.AltaCapataz(nuevoCapataz);
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

            //alta de nuevo ovino
            static void AgregarOvino()
            {
                try
                {
                    //Pedir los datos que necesito para dar de alta un nuevo ovino
                    Console.WriteLine("Ingrese el id de la caravana");
                    string idCaravana = Console.ReadLine();
                    Console.WriteLine("Ingrese el sexo del ovino (Macho o Hembra)");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("Ingrese la raza del ovino");
                    string raza = Console.ReadLine();
                    Console.WriteLine("Ingrese fecha de naciminto");
                    DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento);
                    Console.WriteLine("Ingrese precio de compra");
                    decimal.TryParse(Console.ReadLine(), out decimal precioCompra);
                    Console.WriteLine("Ingrese costo de alimentacion");
                    decimal.TryParse(Console.ReadLine(), out decimal costoAlimentacion);
                    Console.WriteLine("Ingrese peso actual del ovino");
                    decimal.TryParse(Console.ReadLine(), out decimal pesoActual);
                    Console.WriteLine("Ingrese si es hibrido s-si y n-no");
                    string hibrido = Console.ReadLine();
                    Console.WriteLine("Ingrese el peso de la lana");
                    int.TryParse(Console.ReadLine(), out int pesoLana);
                    hibrido.ToUpper();
                    bool esHibrido = false;

                    if (hibrido.Trim() == "S")
                    {
                        esHibrido = true;
                    }
                    if (!string.IsNullOrEmpty(idCaravana) && !string.IsNullOrEmpty(sexo) && !string.IsNullOrEmpty(raza) && fechaNacimiento > DateTime.MinValue && precioCompra > 0 && costoAlimentacion > 0 && pesoActual > 0 && pesoLana > 0)
                    {
                        Ovino nuevoOvino = new Ovino(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, esHibrido, pesoLana);
                        _miSistema.AltaOvino(nuevoOvino);
                        Console.WriteLine("El ovino se agrego correctamente");
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

            //alta de nuevo bovino
            static void AgregarBovino()
            {
                try
                {
                    //Pedir los datos que necesito para dar de alta un nuevo bovino
                    Console.WriteLine("Ingrese el id de la caravana");
                    string idCaravana = Console.ReadLine();
                    Console.WriteLine("Ingrese el sexo del ovino (Macho o Hembra)");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("Ingrese la raza del ovino");
                    string raza = Console.ReadLine();
                    Console.WriteLine("Ingrese fecha de naciminto");
                    DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento);
                    Console.WriteLine("Ingrese precio de compra");
                    decimal.TryParse(Console.ReadLine(), out decimal precioCompra);
                    Console.WriteLine("Ingrese costo de alimentacion");
                    decimal.TryParse(Console.ReadLine(), out decimal costoAlimentacion);
                    Console.WriteLine("Ingrese peso actual del ovino");
                    decimal.TryParse(Console.ReadLine(), out decimal pesoActual);
                    Console.WriteLine("Ingrese si es hibrido s-si y n-no");
                    string hibrido = Console.ReadLine();
                    Console.WriteLine("Ingrese el tipo de alimentacion");
                    string tipoAlimentacion = Console.ReadLine();
                    hibrido.ToUpper();
                    bool esHibrido = false;

                    if (hibrido.Trim() == "S")
                    {
                        esHibrido = true;
                    }
                    if (!string.IsNullOrEmpty(idCaravana) && !string.IsNullOrEmpty(sexo) && !string.IsNullOrEmpty(raza) && fechaNacimiento > DateTime.MinValue && precioCompra > 0 && costoAlimentacion > 0 && pesoActual > 0 && !string.IsNullOrEmpty(tipoAlimentacion))
                    {
                        Bovino nuevoBovino = new Bovino(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, esHibrido, tipoAlimentacion);
                        _miSistema.AltaBovino(nuevoBovino);
                        Console.WriteLine("El bovino se agrego correctamente");
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

            //listamos animales
            static void MostrarListadoDeAnimales()
            {
                    foreach (Ganado ganado in _miSistema.Animales)
                    {
                        Console.WriteLine(ganado);
                        Console.WriteLine("------------------------------------------------------------------");
                    }


            }

            //
            static void MostrarPotrerosConAreaYCapacidad()
            {
                try
                {
                    Console.WriteLine("Ingrese la cantidad de hectáreas:");
                    decimal.TryParse(Console.ReadLine(),out decimal areaMinima);

                    Console.WriteLine("Ingrese el número máximo de capacidad:");
                    int.TryParse(Console.ReadLine(),out int capacidadMaxima);

                    foreach (Potrero potrero in _miSistema.Potreros)
                    {
                        if (potrero.Hectareas > areaMinima && potrero.CapacidadMaxima > capacidadMaxima)
                        {
                            Console.WriteLine(potrero);
                            Console.WriteLine("------------------------------------------------------------------");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al mostrar potreros: {ex.Message}");
                }
            }

            static void EstablecerPrecioLanaOvinos()
            {
                try
                {
                    Console.WriteLine("Ingrese el precio por kilogramo de lana para los ovinos:");
                    decimal.TryParse(Console.ReadLine(), out decimal precioLana);


                    // Establecer el precio en la clase Sistema
                    _miSistema.EstablecerPrecioLanaOvinos(precioLana);

                    Console.WriteLine($"El precio por kilogramo de lana de ovinos es {precioLana}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al establecer el precio de la lana de los ovinos: {ex.Message}");
                }
            }

        }


    }
    
}
    


