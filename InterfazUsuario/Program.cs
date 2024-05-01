using LogicaNegocio;
using System.Linq.Expressions;
namespace InterfazUsuario
{
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
                Console.WriteLine("2-Agregar ovino");
                Console.WriteLine("3-Agregar bovino");
                Console.WriteLine("0-Salir");
            }

            static void VerificarOpcionSeleccionada(int opcion)
            {
                switch (opcion)
                {
                    case 1:
                        mostrarListadoDeAnimales();
                        break;
                    case 2:
                        AgregarOvino();
                        break;
                    case 3:
                        AgregarBovino();
                        break;
                    case 4:
                        //MostrarPotrerosConAreaYCapacidad();
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

            static void AgregarOvino()
            {
                try
                {
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

            static void AgregarBovino()
            {
                try
                {
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
            static void mostrarListadoDeAnimales()
            {
                
                    if (_miSistema.Animales.Count == 0)
                    {
                        Console.WriteLine("No hay animales registrados.");
                        return;
                    }

                    Console.WriteLine("Listado de Animales:");
                    foreach (Ganado ganado in _miSistema.Animales)
                    {
                        Console.WriteLine(ganado);
                    }
                
                
            }

            /*static void MostrarPotrerosConAreaYCapacidad()
            {
                try
                {
                    Console.WriteLine("Ingrese la cantidad de hectáreas:");
                    decimal areaMinima = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Ingrese el número máximo de capacidad:");
                    int capacidadMaxima = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Potreros con área mayor a {0} hectáreas y capacidad máxima superior a {1}:", areaMinima, capacidadMaxima);
                    Console.WriteLine("-------------------------------------------------------------");

                    foreach (Potrero potrero in _miSistema.Potreros)
                    {
                        if (potrero.Hectareas > areaMinima && potrero.CapacidadMaxima > capacidadMaxima)
                        {
                            MostrarDetallesPotrero(potrero);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al mostrar potreros: {ex.Message}");
                }
            }

            static void MostrarDetallesPotrero(Potrero potrero)
            {
                Console.WriteLine("Identificador: {0}", potrero.Id);
                Console.WriteLine("Descripción: {0}", potrero.Descripcion);
                Console.WriteLine("Hectáreas: {0}", potrero.Hectareas);
                Console.WriteLine("Capacidad Máxima: {0}", potrero.CapacidadMaxima);
                Console.WriteLine("-------------------------------------------------------------");
            }*/

        }


    }
    
}
    


