using DTO;
using EjercicioU10.ViewModels.Utilidades;
using SERVICES;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonaApiService.ViewModels
{
    [QueryProperty(nameof(PersonaEditar), "Persona")]
    class EditarPersonaVM: INotifyPropertyChanged
    {
        #region Atributos
        private ClsPersona personaEditar;

        private List<ClsDepartamento> listadodepartamentos;

        private ClsDepartamento departamentoSeleccionado;

        private DelegateCommand guardarPersona;

        private DelegateCommand volverPersona;
        #endregion

        #region Propiedades
        public ClsPersona PersonaEditar { get{ return personaEditar; } set { personaEditar = value; NotifyPropertyChanged("PersonaEditar"); } }
        public List<ClsDepartamento> ListadoDepartamentos { get { return listadodepartamentos; } }
        public ClsDepartamento DepartamentoSeleccionado { get { return departamentoSeleccionado; } set { departamentoSeleccionado = value; NotifyPropertyChanged("DepartamentoSeleccionado"); } }
        public DelegateCommand GuardarPersona { get { return guardarPersona; } set { guardarPersona = value; } }
        public DelegateCommand VolverPersona { get { return volverPersona; } set { volverPersona = value; } }
        #endregion

        #region Constructores
        public EditarPersonaVM()
        {
            CargarDepartamentos();
            listadodepartamentos = new List<ClsDepartamento>();
            guardarPersona = new DelegateCommand(GuardarPersonaExecute);
            volverPersona = new DelegateCommand(VolverPersonaExecute);
        }
        #endregion

        #region Commands
        private async void GuardarPersonaExecute()
        {
            HttpStatusCode status;
            personaEditar.IdDepartamento = departamentoSeleccionado.Id;
            status = await Services.EditarPersona(personaEditar);
            if (status == HttpStatusCode.OK)
            {
                await App.Current.MainPage.DisplayAlert("Información", "Persona editada", "Aceptar");
                await Shell.Current.GoToAsync("///Personas");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Información", "Error con la base de datos", "Aceptar");
            }
        }


        private async void VolverPersonaExecute()
        {
            await Shell.Current.GoToAsync("///Personas");
        }
        #endregion

        #region Métodos
        private async void CargarDepartamentos()
        {
            listadodepartamentos = await Services.GetDepartamentos();
            NotifyPropertyChanged("ListadoDepartamentos");
            NotifyPropertyChanged("DepartamentoSeleccionado");

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
