using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EJercicio02.Models.ENT
{


    internal class ClsPersona: INotifyPropertyChanged
    {
        #region Atributos
        private string nombre = "";
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                NotifyPropertyChanged("Nombre");
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
    }


}