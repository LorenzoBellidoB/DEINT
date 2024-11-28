using BL;
using ENT;
using MandalorianoDificil.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoDificil.ViewModels
{
    public class ListadoMisionesVM: INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsMision> listadoMisiones;
        private ClsMision misionSeleccionada;
        private DelegateCommand completarCommand;

        #endregion

        #region Propiedades
        public List<ClsMision> ListadoMisiones
        {
            get { return listadoMisiones; }            
        }

        public ClsMision MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set { misionSeleccionada = value; completarCommand.RaiseCanExecuteChanged(); NotifyPropertyChanged("MisionSeleccionada");}
        }   

        public DelegateCommand CompletarCommand
        {
            get { return completarCommand; }
        }

        #endregion

        #region Constructores
        public ListadoMisionesVM()
        {
            listadoMisiones = ListadoMisionesBl.obtenerListadoMisionesBl();
            completarCommand = new DelegateCommand(completarCommand_Executed, completarCommand_CanExecute);
        }

        #endregion

        #region Metodos
        private async void completarCommand_Executed()
        {
            Dictionary<string, object> diccionarioMandar = new Dictionary<string, object>();

            diccionarioMandar.Add("MisionCompletada", MisionSeleccionada);

            await Shell.Current.GoToAsync("///MisionesCompletadas", diccionarioMandar);

            listadoMisiones.Remove(MisionSeleccionada);

            NotifyPropertyChanged("ListadoMisiones");
        }
        private bool completarCommand_CanExecute()
        {
            bool res = false;

            if (misionSeleccionada != null)
            {
                res = true;
            }

            return res;
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
