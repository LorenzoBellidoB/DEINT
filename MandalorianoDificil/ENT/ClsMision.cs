using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsMision
    {
        private int idMision;
        private string nombre;
        private string descripcion;
        private double recompensa;

        public int IdMision 
        { 
            get { return idMision; }
            set { idMision = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Recompensa
        {
            get { return recompensa; }
            set { recompensa = value; }
        }

        public ClsMision()
        {
            idMision = 0;
            nombre = "";
            descripcion = "";
            recompensa = 0;
        }

        public ClsMision(int idMision, string nombre, string descripcion, double recompensa)
        {
            this.idMision = idMision;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.recompensa = recompensa;
        }
    }
}
