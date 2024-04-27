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
    }
        
    
}
    


