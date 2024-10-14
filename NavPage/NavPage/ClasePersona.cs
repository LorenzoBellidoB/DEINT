namespace NavPage
{
    public class ClasePersona
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
        public ClasePersona()
        {
            nombre = "Marco";
            apellido = "Holguin";
        }

        public ClasePersona(string nombre, string apellido, int edad, DateOnly fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    
}
}