using ENT;
using MandalorianoDificil.Models;
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
    [QueryProperty(nameof(Mision), "MisionCompletada")]
    public class ListadoMisionesCompletadasVM: INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsMision> listadoMisiones;

        private List<ClsMisionCompletada> listadoMisionesCompletadas;

        private ClsMision mision;

        private DelegateCommand volverCommand;
        #endregion

        #region Propiedades
        public List<ClsMisionCompletada> ListadoMisionesCompletadas
        {
            get { return listadoMisionesCompletadas; }
        }

        public ClsMision Mision
        {
            get { return mision; }
            set { mision = value; 
                ClsMisionCompletada misionCompletada = new ClsMisionCompletada(value);
                listadoMisionesCompletadas.Add(misionCompletada);
                NotifyPropertyChanged("Mision");
                NotifyPropertyChanged("ListadoMisionesCompletadas");
            }
        }

        public DelegateCommand VolverCommand
        {
            get { return volverCommand; }
        }

        #endregion

        #region Constructores
        public ListadoMisionesCompletadasVM()
        {
            listadoMisionesCompletadas = new List<ClsMisionCompletada>();
            volverCommand = new DelegateCommand(volverCommand_Executed);
        }
        #endregion

        #region Metodos
        private async void volverCommand_Executed()
        {
            await Shell.Current.GoToAsync("///ListadoMisiones");
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
