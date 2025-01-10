using DTO;
using EjercicioU10.ViewModels.Utilidades;
using SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        #endregion

        #region Propiedades
        public List<ClsPersona> ListadoPersonas { get { return listadoPersonas; } set { listadoPersonas = value; } }
        public DelegateCommand MostrarPersonas { get{return mostrarPersonas; } set { mostrarPersonas = value; } }
        public DelegateCommand EliminarPersona { get { return eliminarPersona; } set { eliminarPersona = value; } }
        public ClsPersona PersonaSeleccionada { get { return personaSeleccionada; } set { personaSeleccionada = value; NotifyPropertyChanged("PersonaSeleccionada");} }
        #endregion

        #region Constructor
        public PersonasVM()
        {
            listadoPersonas = new List<ClsPersona>();
            mostrarPersonas = new DelegateCommand(MostrarListadoExecute);
            eliminarPersona = new DelegateCommand(EliminarPersonaExecute, CanEliminarPersonaExecute);
        }
        #endregion

        #region Commands
        private async void MostrarListadoExecute()
        {
            try
            {
                listadoPersonas = await Services.getPersonas();

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
            int id = personaSeleccionada.Id;
            int row = 0;
            try
            {
                await Services.eliminarPersona(id);
                MostrarListadoExecute();
            }
            catch (Exception ex)
            {
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
