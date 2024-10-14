namespace ClasePersona
{

    public class Class1
    {
        #region Atributos
        private string nombre;
        private string apellido;
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
            set { apellido = value; }
        }
        #endregion

        #region Constructores
        public Class1()
        {
            nombre = "Marco";
            apellido = "Holguin";
            edad = 18;
        }

        public Class1(string nombre, string apellido, int edad, DateOnly fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    }
}
