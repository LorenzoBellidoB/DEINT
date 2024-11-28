using BL;
using ENT;
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
    public class ListadoMisionesCandidatosVM: INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsMision> listadoMisiones;
        private List<ClsCandidato> listadoCandidatos;
        private List<ClsCandidatoEdad> listadoCandidatosEdad;
        private ClsMision misionSeleccionada;
        private ClsCandidatoEdad candidatoSeleccionado;
        private bool mostrar = false;
        private DelegateCommand seleccionarCommand;
        private DelegateCommand detallesCommand;
        #endregion

        #region Propiedades
        public List<ClsMision> ListadoMisiones
        {
            get { return listadoMisiones; }
        }

        public List<ClsCandidatoEdad> ListadoCandidatosEdad
        {
            get { return listadoCandidatosEdad; }
        }

        public ClsMision MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set
            {
                misionSeleccionada = value;
                listadoCandidatos = ClsListadosBl.obtenerListadoCandidatosBl(value.Dificultad);
                listadoCandidatosEdad = new List<ClsCandidatoEdad>();
                foreach (ClsCandidato cand in listadoCandidatos){
                    ClsCandidatoEdad candidatoEdad = new ClsCandidatoEdad(cand);
                    listadoCandidatosEdad.Add(candidatoEdad);
                }
                NotifyPropertyChanged("ListadoCandidatosEdad");
            }
        }
        public ClsCandidatoEdad CandidatoSeleccionado
        {
            get { return candidatoSeleccionado; }
            set
            {
                detallesCommand.RaiseCanExecuteChanged();
                candidatoSeleccionado = value;
            }
        }

        public bool Mostrar
        {
            get { return mostrar; }
        }

        public DelegateCommand SeleccionarCommand
        {
            get { return seleccionarCommand; }
        }

        public DelegateCommand DetallesCommand
        {
            get { return detallesCommand; }
        }
        #endregion

        #region Constructores
        public ListadoMisionesCandidatosVM()
        {
            listadoMisiones = ClsListadosBl.obtenerListadoMisionesBl();
            detallesCommand = new DelegateCommand(DetallesCommandExecute, DetallesCommandCanExecute);
        }
        #endregion

        #region Commands
        private async void DetallesCommandExecute()
        {
            Dictionary<string, object> diccionarioMandar = new Dictionary<string, object>();

            diccionarioMandar.Add("Candidato", CandidatoSeleccionado);

            await Shell.Current.GoToAsync("///Detalles", diccionarioMandar);
        }

        private bool DetallesCommandCanExecute()
        {
            bool res = false;

            if (candidatoSeleccionado != null)
            {
                res = true;
            }

            return res;
        }
        #endregion

        #region Métodos
        
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
