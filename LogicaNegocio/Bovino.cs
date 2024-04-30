using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Bovino:Ganado , IValidable
    {
        private string _tipoAlimentacion;
        private static decimal s_precioKgBovino;

        public Bovino(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido, string tipoAlimentacion)
            : base(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, hibrido)
        {
            _tipoAlimentacion = tipoAlimentacion;
        }
    }
}
