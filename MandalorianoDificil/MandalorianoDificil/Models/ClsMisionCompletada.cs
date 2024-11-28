using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoDificil.Models
{
    public class ClsMisionCompletada: ClsMision
    {
        private DateTime fechaFinalizada;

        public DateTime FechaFinalizada
        {
            get { return fechaFinalizada; }
        }

        public ClsMisionCompletada(ClsMision mision)
        {
            this.IdMision = mision.IdMision;
            this.Nombre = mision.Nombre;
            this.Descripcion = mision.Descripcion;
            this.Recompensa = mision.Recompensa;

            insertarFecha();
        }

        private void insertarFecha()
        {
            fechaFinalizada = DateTime.Now;
        }
    }
}
