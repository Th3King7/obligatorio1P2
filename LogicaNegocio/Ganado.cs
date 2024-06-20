using LogicaNegocio.Interfaces;

namespace LogicaNegocio
{
    public abstract class Ganado :IEquatable<Ganado>, IValidable
    {
        private string _idCaravana;
        private string _sexo;
        private string _raza;
        private DateTime _fechaNacimiento;
        private decimal _precioCompra;
        private decimal _costoAlimentacion;
        private decimal _pesoActual;
        private bool _hibrido;
        private List<Vacunado> _vacunasDadas = new List<Vacunado>();
        //creamos la propiedad de _idCaravana
        public string IdCaravana
        {
            get { return _idCaravana; }
            set { _idCaravana = value; }
        }
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }

        }
        public string Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public decimal PrecioCompra
        {
            get { return _precioCompra; }
            set { _precioCompra = value; }
        }
        public decimal CostoAlimentacion
        {
            get { return _costoAlimentacion; }
            set { _costoAlimentacion = value; }
        }
        public decimal PesoActual
        {
            get { return _pesoActual; }
            set { _pesoActual = value; }
        }
        public bool Hibrido
        {
            get { return _hibrido; }
            set { _hibrido = value; }
        }
        //creamos el metodo constructor
        public Ganado(string idCaravana, string sexo, string raza, DateTime fechaNacimiento, decimal precioCompra, decimal costoAlimentacion, decimal pesoActual, bool hibrido)
        {
            _idCaravana = idCaravana;
            _sexo = sexo;
            _raza = raza;
            _fechaNacimiento = fechaNacimiento;
            _precioCompra = precioCompra;
            _costoAlimentacion = costoAlimentacion;
            _pesoActual = pesoActual;
            _hibrido = hibrido;
            precargaVacunados();
        }

        public bool Equals(Ganado? other)
        {
            // Si other es nulo, no son iguales
            if (other == null)
            {
                return false;
            }

            return _idCaravana == other._idCaravana;
        }

        private void precargaVacunados()
        {
            AltaVacunado(new Vacunado(
                new Vacuna("Bovilis BVD", "Vacuna para bovinos contra la diarrea viral bovina", "Diarrea viral bovina"),
                new DateTime(2023, 4, 15), new DateTime(2024, 4, 15)));

            AltaVacunado(new Vacunado(
                new Vacuna("Bovi-Shield Gold FP 5", "Vacuna para bovinos contra la fiebre aftosa, rinotraqueítis infecciosa bovina, parainfluenza-3, virus de la diarrea viral bovina y virus de la enfermedad de la lengua azul", "Fiebre aftosa, Rinotraqueítis infecciosa bovina, Parainfluenza-3, Diarrea viral bovina, Enfermedad de la lengua azul"),
                new DateTime(2023, 5, 20), new DateTime(2024, 5, 20)));

            AltaVacunado(new Vacunado(
                new Vacuna("Scour Bos 9", "Vacuna para bovinos contra la diarrea neonatal", "Diarrea neonatal en terneros"),
                new DateTime(2023, 6, 10), new DateTime(2024, 6, 10)));

            AltaVacunado(new Vacunado(
                new Vacuna("Cydectin Injectable", "Vacuna para bovinos contra parásitos internos y externos", "Parásitos internos y externos en bovinos"),
                new DateTime(2023, 7, 5), new DateTime(2024, 7, 5)));

            AltaVacunado(new Vacunado(
                new Vacuna("Ovilis Enzovax", "Vacuna para ovinos contra la enzootic abortion", "Aborto enzoótico en ovejas"),
                new DateTime(2023, 8, 15), new DateTime(2024, 8, 15)));

            AltaVacunado(new Vacunado(
                new Vacuna("Ovivac P Plus", "Vacuna para ovinos contra la pulmonía", "Pulmonía en ovejas"),
                new DateTime(2023, 9, 20), new DateTime(2024, 9, 20)));

            AltaVacunado(new Vacunado(
                new Vacuna("BoviVac IBR Marker Live", "Vacuna para bovinos contra la rinotraqueítis infecciosa bovina", "Rinotraqueítis infecciosa bovina"),
                new DateTime(2023, 10, 10), new DateTime(2024, 10, 10)));

            AltaVacunado(new Vacunado(
                new Vacuna("Footvax", "Vacuna para ovinos contra la fiebre aftosa", "Fiebre aftosa en ovejas"),
                new DateTime(2023, 11, 5), new DateTime(2024, 11, 5)));

            AltaVacunado(new Vacunado(
                new Vacuna("Bovilis IBR Marker Inact", "Vacuna para bovinos contra la rinotraqueítis infecciosa bovina", "Rinotraqueítis infecciosa bovina"),
                new DateTime(2023, 12, 15), new DateTime(2024, 12, 15)));

            AltaVacunado(new Vacunado(
                new Vacuna("Bravoxin 10", "Vacuna para ovinos contra el carbunco", "Carbunco en ovejas"),
                new DateTime(2023, 1, 20), new DateTime(2024, 1, 20)));
        }

        //validamos que al atributo _idCaravana su longitud de caracteres no sea menor a 8
        //validamos que al atributo _sexo sea  Macho o Hembra 
        //validamos que al atributo _raza sea Merino, Angus o Hereford
        //validamos que al atributo _fechaDeNacimiento no sea posterior a la actual
        //validamos que al atributo _precioCompra no sea menor a 0 
        //validamos que al atributo _costoAlimentacion no sea menor a 0 
        //validamos que al atributo _pesoActual no sea menor a 0 

        public void ValidarDatos()
        {
            if(_idCaravana.Length < 8)
            {
                throw new Exception("el id debe ser en formato alfanumerico de 8 digitos");
            }
            if( _sexo != "Macho" && _sexo != "Hembra")
            {
                throw new Exception("el sexo debe ser en Macho o Hembra ");

            }
            if (_raza != "Merino" && _raza != "Angus" && _raza != "Hereford")
            {
                throw new Exception("la raza debe ser: Merino, Angus , Hereford ");

            }
            if (_fechaNacimiento > DateTime.Now)
            {
                throw new Exception("La fecha es incorrecta");
            }
            if(_precioCompra < 0)
            {
                throw new Exception("El precio de compra del animal tiene que ser mayor a 0");

            }
            if (_costoAlimentacion < 0)
            {
                throw new Exception("El costo de alimetacion del animal tiene que ser mayor a 0");

            }
            if (_pesoActual < 0)
            {
                throw new Exception("El peso actual del animal tiene que ser mayor a 0");

            }
          
        }

        public void AltaVacunado(Vacunado nuevoAnimalVacunado)
        {
            //Validar datos de la nueva vacunacion
            nuevoAnimalVacunado.ValidarDatos();
            //Verificar si no existe en mi lista de vacunado la vacuna ya dada  con el mismo valor en su atributo identificatorio
            if (!_vacunasDadas.Contains(nuevoAnimalVacunado))
            {
                //Si no existe una vacuna dada con el mismo valor en su atributo identificatorio, agrego el bovino a la lista
                _vacunasDadas.Add(nuevoAnimalVacunado);
            }
            else
            {
                throw new Exception("Ya se le dio la vacuna al animal");
            }
        }

        public abstract bool ObtenerAnimal(string idCaravana);

        public abstract decimal CalcularCostoCrianza();

        public int CantidadDeVacunas()
        {
            return _vacunasDadas.Count;
        }
        public abstract decimal CalcularPrecioVenta();


        //modificamos el metodo ToString de Object para que muestre lo siguiente
        public override string ToString()
        {
            return $"ID: {_idCaravana}, Raza: {_raza}, Peso: {_pesoActual}, Sexo: {_sexo}";
        }
    }

        

}
