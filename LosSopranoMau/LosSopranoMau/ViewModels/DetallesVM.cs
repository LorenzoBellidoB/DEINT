using LosSopranoMau.Models;
using LosSopranoMau.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LosSopranoMau.ViewModels
{
    [QueryProperty(nameof(CandidatoDetalles), "Candidato")]
    public class DetallesVM: INotifyPropertyChanged
    {
        private DelegateCommand volverCommand;

        private ClsCandidatoEdad candidatoDetalles;

        public ClsCandidatoEdad CandidatoDetalles 
        {

            get { return candidatoDetalles; }
            set { candidatoDetalles = value; NotifyPropertyChanged("CandidatoDetalles"); }
        }

        public DelegateCommand VolverCommand
        {
            get {return volverCommand;}
        }

        private async void VolverCommandExecute()
        {
            await Shell.Current.GoToAsync("///Principal");
        }

        public bool VolverCommandCanExecute()
        {
            bool res = false;

            if (CandidatoDetalles != null)
            {
                res = true;
            }

            return res;
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
