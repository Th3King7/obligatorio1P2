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
        //creamos el metodo constructor
        public Ovino(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido, decimal pesoLana)
            :base(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, hibrido)
        {
            _pesoLana = pesoLana;
        }
        //creamos la propiedad de s_precioLana
        public decimal PrecioLana
        {
            set { s_precioLana = value; } 
            get { return s_precioLana; }
        }
        //validamos que al atributo _peso lana no sea menor a 0 

        public void ValidarDatos()
        {
            base.ValidarDatos();
            if (_pesoLana < 0)
            {
                throw new Exception("el peso de lana debe ser mayor que 0");

            }
        }

        public override bool ObtenerAnimal(string idAnimal)
        {
            bool ovinoEnconrado = false;
            if (idAnimal == IdCaravana)
            {
                ovinoEnconrado = true;
            }
            return ovinoEnconrado;
        }
       
    }
}
