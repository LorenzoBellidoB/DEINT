using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsCasilla: INotifyPropertyChanged
    {
        #region Atributos
        private bool esBomba = false;

        private bool revelado = false;

        private string imagen = "norevelado.png";
        #endregion

        #region Propiedades
        public bool EsBomba { get => esBomba; set => esBomba = value; }
        public bool Revelado {
            get
            {
                return revelado;
            } 
            set{
                revelado = value;
                if (revelado)
                {
                    if (esBomba)
                    {
                        imagen = "bomba.png";
                    }
                    else
                    {
                        imagen = "acierto.png";
                    }
                }
                NotifyPropertyChanged("Imagen");
            }

        }
        public string Imagen { get => imagen; set => imagen = value; }
        #endregion

        #region Constructores

        public ClsCasilla() { }
        public ClsCasilla(bool esBomba)
        {
            this.esBomba = esBomba;
        }

        #endregion

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new
            PropertyChangedEventArgs(propertyName));

        }
        #endregion
    }
}
