using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosSopranoMau.Models
{
    public class ClsCandidatoEdad: ClsCandidato
    {
        private int edad;
        public int Edad {get { return edad; } }

        public ClsCandidatoEdad(ClsCandidato candidato) 
        {
            this.Id = candidato.Id;
            this.Nombre = candidato.Nombre;
            this.Apellidos = candidato.Apellidos;
            this.Direccion = candidato.Direccion;
            this.Pais = candidato.Pais;
            this.Telefono = candidato.Telefono;
            this.FechaNac = candidato.FechaNac;
            this.Sueldo = candidato.Sueldo;

            getEdad();
        }

        private void getEdad()
        {
            this.edad = DateTime.Now.Year - this.FechaNac.Year;
        }
    }
}
