using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Ovino:Ganado, IValidable
    {
        private decimal _pesoLana;
        private static decimal s_precioLana;
        private static decimal s_precioKgOvino;

        public Ovino(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido, decimal pesoLana)
            :base(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, hibrido)
        {
            _pesoLana = pesoLana;
        }

        public void ValidarDatos()
        {
            base.ValidarDatos();



        }
    }
}
