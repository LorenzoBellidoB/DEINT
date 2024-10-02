using System.Runtime.CompilerServices;

namespace BibliotecaClases
{
    public class ClsPersona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private int edad;
        #endregion

        #region Propiedades
        //public string NombreAutoImplementada { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;  }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Edad
        {
            get{ return edad; }
        }
        #endregion

        #region Constructores
        public ClsPersona() 
        {
            nombre = "Marco";
            apellido = "Holguin";
            edad = 18;
        }

        public ClsPersona(string nombre, string apellido, int edad, DateOnly fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
        }
        #endregion
    }
}
