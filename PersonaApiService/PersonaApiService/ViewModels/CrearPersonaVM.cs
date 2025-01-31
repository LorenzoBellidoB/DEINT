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
    class CrearPersonaVM: INotifyPropertyChanged
    {
        #region Atributos
        private ClsPersona personaCreada;
        private List<ClsDepartamento> listadodepartamentos;
        private ClsDepartamento departamentoSeleccionado;
        private string nombre = "";
        private string apellidos = "";
        private string telefono = "";
        private string direccion = "";
        private string foto = "";
        private DateTime fechaNacimiento = DateTime.Now;
        private DelegateCommand crearPersona;
        private DelegateCommand volverPersona;
        #endregion

        #region Propiedades
        public List<ClsDepartamento> ListadoDepartamentos { get { return listadodepartamentos; } }
        public ClsDepartamento DepartamentoSeleccionado { get { return departamentoSeleccionado; } set { departamentoSeleccionado = value; NotifyPropertyChanged("DepartamentoSeleccionado"); } }

        public string Nombre { get { return nombre; } set { nombre = value; crearPersona.RaiseCanExecuteChanged();} }
        public string Apellidos { get {return apellidos; } set { apellidos = value; crearPersona.RaiseCanExecuteChanged(); } }
        public string Telefono { get { return telefono; } set { telefono = value; crearPersona.RaiseCanExecuteChanged(); } }
        public string Direccion { get { return direccion; } set { direccion = value; crearPersona.RaiseCanExecuteChanged(); } }
        public string Foto { get { return foto; } set { foto = value; crearPersona.RaiseCanExecuteChanged(); } }   
        public DateTime FechaNacimiento { get { return fechaNacimiento; }  set { fechaNacimiento = value; crearPersona.RaiseCanExecuteChanged(); } }
         public DelegateCommand CrearPersona { get { return crearPersona; } }  
        public DelegateCommand VolverPersona { get { return volverPersona; } }
        #endregion

        #region Constructores
        public CrearPersonaVM()
        {
            personaCreada = new ClsPersona();
            CargarDepartamentos();
            crearPersona = new DelegateCommand(CrearPersonaExecute,CanCrearPersonaExecute);
            volverPersona = new DelegateCommand(VolverPersonaExecute);
        }
        #endregion

        #region Commands
        private async void CrearPersonaExecute()
        {
            try
            {
                HttpStatusCode status;
                personaCreada.Nombre = nombre;
                personaCreada.Apellidos = apellidos;
                personaCreada.Telefono = telefono;
                personaCreada.Direccion = direccion;
                personaCreada.Foto = foto;
                personaCreada.FechaNacimiento = fechaNacimiento;
                personaCreada.IdDepartamento = departamentoSeleccionado.Id;
                if (personaCreada != null)
                {
                status = await Services.CrearPersona(personaCreada);
                if (status == HttpStatusCode.OK)
                    {
                        await App.Current.MainPage.DisplayAlert("Información", "Persona creada", "Aceptar");
                        await Shell.Current.GoToAsync("///Personas");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Información", "Error al crear la persona", "Aceptar");
                        await Shell.Current.GoToAsync("///Personas");
                    }
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Información", "Error con la base de datos", "Aceptar");
                }
            }
            catch (Exception ex)
            {

            }
            
        }
        private bool CanCrearPersonaExecute()
        {
            bool crear = false;
            if (PersonaRellena())
            {
                crear = true;
            }
            return crear;
        }

        private async void VolverPersonaExecute()
        {
            await Shell.Current.GoToAsync("///Personas");
        }
        #endregion

        #region Funciones
        private bool PersonaRellena()
        {
            bool rellena = false;
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellidos) && !String.IsNullOrEmpty(telefono)
                && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(foto)
                && !String.IsNullOrEmpty(fechaNacimiento.ToString()))
            {
                rellena = true;
            }
            return rellena;
        }
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
