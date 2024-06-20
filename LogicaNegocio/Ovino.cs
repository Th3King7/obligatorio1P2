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
        private static decimal s_precioLana =50;
        private static decimal s_precioKgOvino = 100;
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
        //Metodo modificado declarado en la clase padre .
        public override bool ObtenerAnimal(string idAnimal)
        {
            if (!string.IsNullOrEmpty(idAnimal))
            {
      bool ovinoEnconrado = false;
            if (idAnimal == IdCaravana)
            {
                ovinoEnconrado = true;
            }
            return ovinoEnconrado;
            }else
            {
                throw new Exception("No se encontro animal");
                ;
            }

          
        }
        //Calculamos costo de crianza mediante el metodo modificado y declarado en la clase padre

        public override decimal CalcularCostoCrianza()
        {
            decimal costoTotal = this.PrecioCompra + this.CostoAlimentacion;
            costoTotal += 200 * CantidadDeVacunas(); // Sumar costo de vacunas

            return costoTotal;
        }

        //Calculamos precio de venta mediante el metodo modificado y declarado en la clase padre
        public override decimal CalcularPrecioVenta()
        {
            decimal precioVenta = (_pesoLana * s_precioLana) + (s_precioKgOvino * this.PesoActual);

            if (this.Hibrido)
            {
                precioVenta *= 0.95m; // Aplicar descuento del 5% si es híbrido
                                      // m es un tipo de dato numérico que se utiliza para representar números de punto flotante con mayor precisión y rango que float o double.
            }

            return precioVenta;
        }
    }
}
