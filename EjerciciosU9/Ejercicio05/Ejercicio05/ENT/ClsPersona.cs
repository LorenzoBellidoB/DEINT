using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    /// <summary>
    /// Clase que guardará las propiedades de una persona
    /// </summary>
    public class ClsPersona
    {
        #region Atributos
        private string nombre = "";
        private string apellido = "";
        private DateTime fechaNacimiento;
        private string foto = "";
        private string direccion = "";
        private string telefono = "";
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        #endregion

        #region Constructor
        public ClsPersona() { }
        public ClsPersona(string nombre, string apellido, DateTime fechaNacimiento, string foto, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.foto = foto;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        #endregion
    }
}
