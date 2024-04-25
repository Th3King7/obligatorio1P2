namespace LogicaNegocio
{
    public class Tarea
    {
        private int _id;
        private static int s_ultid;
        private string _descripcion;
        private DateTime _fechaInicio;
        private DateTime _fechaCierre;
        private bool _tareaCompletada;
        private string _comentario;
    }
}