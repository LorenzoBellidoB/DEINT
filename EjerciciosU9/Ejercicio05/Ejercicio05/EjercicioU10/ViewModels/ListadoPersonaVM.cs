using BL;
using EjercicioU10.ViewModels.Utilidades;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciou10.ViewModels
{
    /// <summary>
    /// ViewModel para el listado de personas
    /// </summary>
    public class ListadoPersonaVM : INotifyPropertyChanged
    {
        #region Atributos
        // Comando para eliminar una persona
        private DelegateCommand eliminarCommand;
        // Comando para buscar personas
        private DelegateCommand buscarCommand;
        // Texto introducido en el Entry de búsqueda
        private string textoEntry;
        // Persona seleccionada en la lista
        private ClsPersona personaSeleccionada;
        // Lista observable de personas
        private ObservableCollection<ClsPersona> listaPersonas;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ListadoPersonaVM()
        {
            try
            {
                // Inicializa la lista de personas obtenida del negocio
                listaPersonas = new ObservableCollection<ClsPersona>(ClsListadoPersonaBl.ObtenerListadoBl());
                // Inicializa los comandos
                eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                buscarCommand = new DelegateCommand(BuscarCommand_Executed, BuscarCommand_CanExecute);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                ex.Message.ToString();
            }
        }

        /// <summary>
        /// Constructor con parámetro de persona seleccionada
        /// </summary>
        /// <param name="personaSeleccionada">Persona seleccionada</param>
        public ListadoPersonaVM(ClsPersona personaSeleccionada)
        {
            try
            {
                // Inicializa la lista de personas obtenida del negocio
                listaPersonas = new ObservableCollection<ClsPersona>(ClsListadoPersonaBl.ObtenerListadoBl());
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                ex.Message.ToString();
            }
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Comando para eliminar una persona
        /// </summary>
        public DelegateCommand EliminarCommand
        {
            get
            {
                return eliminarCommand;
            }
        }

        /// <summary>
        /// Comando para buscar personas
        /// </summary>
        public DelegateCommand BuscarCommand
        {
            get
            {
                return buscarCommand;
            }
        }

        /// <summary>
        /// Texto introducido en el Entry de búsqueda
        /// </summary>
        public string TextoEntry
        {
            get { return textoEntry; }
            set { textoEntry = value; buscarCommand.RaiseCanExecuteChanged(); NotifyPropertyChanged("TextoEntry"); }
        }

        /// <summary>
        /// Lista observable de personas
        /// </summary>
        public ObservableCollection<ClsPersona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; NotifyPropertyChanged("ListaPersonas"); }
        }

        /// <summary>
        /// Persona seleccionada en la lista
        /// </summary>
        public ClsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { personaSeleccionada = value; eliminarCommand.RaiseCanExecuteChanged(); NotifyPropertyChanged("PersonaSeleccionada"); }
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notifica el cambio de una propiedad
        /// </summary>
        /// <param name="propertyName">Nombre de la propiedad</param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Ejecuta el comando de eliminar persona
        /// </summary>
        private async void EliminarCommand_Executed()
        {
            // Muestra una confirmación antes de eliminar
            bool confirmacion = await ShowTask.MostrarConfirmacionAsync("¿Seguro que quieres borrar la persona?", "Confirmar borrado");
            if (confirmacion)
            {
                // Elimina la persona seleccionada de la lista
                listaPersonas.Remove(personaSeleccionada);
            }
        }

        /// <summary>
        /// Verifica si se puede ejecutar el comando de eliminar persona
        /// </summary>
        /// <returns>True si se puede eliminar, de lo contrario False</returns>
        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;

            // No se puede borrar si no hay una persona seleccionada
            if (personaSeleccionada == null)
            {
                sePuedeBorrar = false;
            }

            return sePuedeBorrar;
        }

        /// <summary>
        /// Ejecuta el comando de buscar personas
        /// </summary>
        private async void BuscarCommand_Executed()
        {
            // Implementación pendiente
        }

        /// <summary>
        /// Verifica si se puede ejecutar el comando de buscar personas
        /// </summary>
        /// <returns>True si se puede buscar, de lo contrario False</returns>
        private bool BuscarCommand_CanExecute()
        {
            bool sePuedeBuscar = true;

            // No se puede buscar si el texto de búsqueda está vacío
            if (string.IsNullOrEmpty(TextoEntry))
            {
                sePuedeBuscar = false;
            }

            return sePuedeBuscar;
        }
        #endregion
    }
}
