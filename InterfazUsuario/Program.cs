using LogicaNegocio;
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

        
        }
    }


