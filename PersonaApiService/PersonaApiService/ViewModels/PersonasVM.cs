using DTO;
using EjercicioU10.ViewModels.Utilidades;
using SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonaApiService.ViewModels
{
    public class PersonasVM : INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsPersona> listadoPersonas;

        private ClsPersona personaSeleccionada;

        private DelegateCommand mostrarPersonas;

        private DelegateCommand eliminarPersona;

        private DelegateCommand crearPersona;

        private DelegateCommand editarPersona;
        #endregion

        #region Propiedades
        public List<ClsPersona> ListadoPersonas { get { return listadoPersonas; } }
        public DelegateCommand MostrarPersonas { get{return mostrarPersonas; } set { mostrarPersonas = value; } }
        public DelegateCommand EliminarPersona { get { return eliminarPersona; } set { eliminarPersona = value; } }
        public DelegateCommand CrearPersona { get { return crearPersona; } set { crearPersona = value; } }
        public DelegateCommand EditarPersona { get { return editarPersona; } set { editarPersona = value; } }
        public ClsPersona PersonaSeleccionada { get { return personaSeleccionada; } set { personaSeleccionada = value; eliminarPersona.RaiseCanExecuteChanged(); editarPersona.RaiseCanExecuteChanged();} }
        #endregion

        #region Constructor
        public PersonasVM()
        {
            listadoPersonas = new List<ClsPersona>();
            mostrarPersonas = new DelegateCommand(MostrarListadoExecute);
            eliminarPersona = new DelegateCommand(EliminarPersonaExecute, CanEliminarPersonaExecute);
            crearPersona = new DelegateCommand(CrearPersonaExecute);
            editarPersona = new DelegateCommand(EditarPersonaExecute, CanEditarPersonaExecute);
        }
        #endregion

        #region Commands
        private async void MostrarListadoExecute()
        {
            try
            {
                listadoPersonas = await Services.GetPersonas();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                NotifyPropertyChanged("ListadoPersonas");
                
            }
        }

        private async void EliminarPersonaExecute()
        {
            bool confirmar = false;
            confirmar = await App.Current.MainPage.DisplayAlert("Confirmación", $"¿Seguro que quieres borrar a {personaSeleccionada.Nombre} {personaSeleccionada.Apellidos}?", "Si", "No");
            if (confirmar)
            {
            try
            {
                HttpStatusCode status;
                status = await Services.EliminarPersona(personaSeleccionada.Id);
                if(status == HttpStatusCode.OK)
                    {
                        await App.Current.MainPage.DisplayAlert("Información", "Persona eliminada", "Aceptar");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Información", "Error al eliminar la persona", "Aceptar");
                    }
                
                MostrarListadoExecute();
            }
            catch (Exception ex)
            {

            }
            }
            
        }

        private bool CanEliminarPersonaExecute()
        {
            bool borrar = false;
            if (personaSeleccionada != null)
            {
                borrar = true;
            }
            return borrar;
        }
        
        private async void CrearPersonaExecute()
        {
            await Shell.Current.GoToAsync("///CrearPersona");
        }

        private async void EditarPersonaExecute()
        {
            Dictionary<string, object> diccionarioMandar = new Dictionary<string, object>();

            diccionarioMandar.Add("Persona", PersonaSeleccionada);

            await Shell.Current.GoToAsync("///EditarPersona", diccionarioMandar);
        }
        private bool CanEditarPersonaExecute()
        {
            bool editar = false;
            if (personaSeleccionada != null)
            {
                editar = true;
            }
            return editar;
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
