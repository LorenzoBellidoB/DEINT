using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.ViewModels
{
    /// <summary>
    /// ViewModel para el listado de personas
    /// </summary>
    public class ListadoPersonaVM: INotifyPropertyChanged
    {
        #region Atributos
        private ClsPersona personaSeleccionada;
        private ObservableCollection<ClsPersona> listaPersonas = new ObservableCollection<ClsPersona>(ClsListadoPersonaBl.ObtenerListadoBl());
        #endregion

        #region Constructor
        public ListadoPersonaVM() { }

        public ListadoPersonaVM(ClsPersona personaSeleccionada) 
        {
            try
            {
                listaPersonas = new ObservableCollection<ClsPersona>(ClsListadoPersonaBl.ObtenerListadoBl());
            }catch (Exception ex) { 
                ex.Message.ToString();
            }
        }
        #endregion

        #region Propiedades
        public ObservableCollection<ClsPersona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; }
        }

        public ClsPersona PersonaSeleccionada{ get { return personaSeleccionada; }
            set{ personaSeleccionada = value; NotifyPropertyChanged("PersonaSeleccionada"); }
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
 