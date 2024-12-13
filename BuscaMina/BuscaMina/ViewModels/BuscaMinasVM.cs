using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using BL;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BuscaMina.ViewModels
{
    public class BuscaMinasVM: INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsCasilla> listadoCasillas = new List<ClsCasilla>();

        private ClsCasilla casillaSeleccionada = new ClsCasilla();

        private int bombas = 0;

        private int acierto = -1;

        private static int dificultad = 1;

        private int tiradas = ClsListadoBl.numTiradasBl(dificultad);
        #endregion

        #region Propiedades
        public List<ClsCasilla> ListadoCasillas { get { return listadoCasillas; } }
        public ClsCasilla CasillaSeleccionada { 
            get { return casillaSeleccionada; } 
            set { 
                casillaSeleccionada = value;
                comprobarPartida();
                if(tiradas == 0)
                {
                    if(bombas < ClsListadoBl.maxBombasBl(dificultad))
                    {
                        Application.Current.MainPage.DisplayAlert("Ganador", "Has ganado", "Aceptar");
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Perdedor", "Has perdido", "Aceptar");
                    }
                }
            } 
        }
        
        public int Bombas { get { return bombas; }  }

        public int Acierto { get { return acierto; } }

        public static int Dificultad { get {   return dificultad; } set { dificultad = value; } }

        public double Tablero { 
            get { 
                double tablero = listadoCasillas.Count;
                return Math.Sqrt(tablero);
                } 
        }

        public int Tiradas 
        { 
            get { return tiradas; }  
        }
        #endregion

        #region Constructor
        public BuscaMinasVM()
        {
            listadoCasillas = ClsListadoBl.listadoCasillasBl(dificultad);
        }
        #endregion

        private void comprobarPartida()
        {
            if (casillaSeleccionada != null && casillaSeleccionada.Revelado == false)
            {
                casillaSeleccionada.Revelado = true;
                if (casillaSeleccionada.EsBomba == true)
                {
                    bombas++;
                }
                else
                {
                    acierto++;
                }
                tiradas--;
            }
            NotifyPropertyChanged("Bombas");
            NotifyPropertyChanged("Acierto");
            NotifyPropertyChanged("Tiradas");
        }

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
