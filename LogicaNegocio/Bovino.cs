using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public class Bovino : Ganado, IValidable
    {
        private string _tipoAlimentacion;
        private static decimal s_precioKgBovino = 100;
        //creamos el metodo constructor
        public Bovino(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido, string tipoAlimentacion)
            : base(idCaravana, sexo, raza, fechaNacimiento, precioCompra, costoAlimentacion, pesoActual, hibrido)
        {
            _tipoAlimentacion = tipoAlimentacion;
        }
        //creamos el metodo constructor vacio

        public Bovino() :
            base("", "", "", DateTime.Now, 0, 0, 0, false)
        {
        }

        public string TipoAlimentacion
        {
            get { return _tipoAlimentacion; }
            set { _tipoAlimentacion = value; }
        }
        //validamos que al atributo _tipoAlimentacion sea Grano o Pasto
        public void ValidarDatos()
        {
            base.ValidarDatos();
            if (_tipoAlimentacion != "Granos" && _tipoAlimentacion != "Pasto")
            {
                throw new Exception("la alimentacion del bovino debe ser en Pasto o Granos ");

            }
        }
        //Metodo modificado declarado en la clase padre .
        public override bool ObtenerAnimal(string idAnimal)
        {
            if (!string.IsNullOrEmpty(idAnimal))
            {
                bool bovinoEnconrado = false;
                if (idAnimal == IdCaravana)
                {
                    bovinoEnconrado = true;
                }
                return bovinoEnconrado;
            }
            else
            {
                throw new Exception("Id animal nulo ");

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
            decimal precioVenta = s_precioKgBovino * this.PesoActual;

            if (_tipoAlimentacion == "Grano")
            {
                precioVenta *= 1.30m; // Aplicar aumento del 30% si fue alimentado a grano
                                      // m es un tipo de dato numérico que se utiliza para representar números de punto flotante con mayor precisión y rango que float o double.
            }

            if (this.Sexo == "Hembra")
            {
                precioVenta *= 1.10m; // Aplicar aumento del 10% si es hembra
                                      // m es un tipo de dato numérico que se utiliza para representar números de punto flotante con mayor precisión y rango que float o double.
            }

            return precioVenta;
        }



    }
}
