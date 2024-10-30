using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EdadViewModel.ViewModels
{
    public class EdadVM : INotifyPropertyChanged
    {
        #region Atributos
        private DateTime fechaNac;
        private int edad = 19;
        #endregion

        #region PropiedadesPublicas
        public DateTime FechaNac { 
            get { return fechaNac; } 
            set { fechaNac = value;
                NotifyPropertyChanged("Edad");
            }
        }
        public int Edad {
        get { 
                edad = CalculaEdad();
                return edad; 
            }
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

        /// <summary>
        /// Función que calcula la edad según la fecha de nacimiento
        /// </summary>
        /// <returns>Edad del usuario</returns>
        private int CalculaEdad()
        {
            int edad = DateTime.Now.Year - FechaNac.Year;

            // Comprueba si el cumpleaños ya ha pasado este año
            if (DateTime.Now.Month < FechaNac.Month ||
                (DateTime.Now.Month == FechaNac.Month && DateTime.Now.Day < FechaNac.Day))
            {
                edad--;
            }

            return edad;
        }
    }
}
