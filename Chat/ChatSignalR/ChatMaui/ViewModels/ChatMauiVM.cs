using ChatMaui.ViewModels.utils;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;

namespace ChatMaui.ViewModels
{
    public class ChatMauiVM: Notify
    {
        #region atributos
        private string grupoActual;
        private string grupo;
        private readonly HubConnection connection;
        private clsMensajeUsuario mensajeUsuario;
        private DelegateCommand enviarCommand;
        private DelegateCommand joinCommand;
        private DelegateCommand leaveCommand;

        private ObservableCollection<clsMensajeUsuario> listaMensajes;

        private string usuario;
        private string mensaje;
        #endregion

        #region propiedades
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; joinCommand.RaiseCanExecuteChanged(); }
        }
        public ObservableCollection<clsMensajeUsuario> ListaMensajes 
        {
            get { return  listaMensajes; }
            set { listaMensajes = value;}
        }
        public string Usuario 
        {
            get { return usuario; }
            set { usuario = value; enviarCommand.RaiseCanExecuteChanged(); }
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; enviarCommand.RaiseCanExecuteChanged(); }
        }

        public DelegateCommand EnviarCommand
        {
            get { return enviarCommand; }
        }

        public DelegateCommand JoinCommand
        {
            get { return joinCommand; }
        }

        public DelegateCommand LeaveCommand
        {
            get { return leaveCommand; }
        }
        #endregion

        #region constructor
        public ChatMauiVM()
        {
            enviarCommand = new DelegateCommand(enviarExecute, enviarCanExecute);
            joinCommand = new DelegateCommand(joinExecute, joinCanExecute);
            leaveCommand = new DelegateCommand(leaveExecute, leaveCanExecute);
            listaMensajes = new ObservableCollection<clsMensajeUsuario>();
            connection = new HubConnectionBuilder().WithUrl("http://localhost:5250/chathub").Build();

            connection.On<clsMensajeUsuario>("ReceiveMessage", (message) =>
            {
                 MainThread.InvokeOnMainThreadAsync(() =>
                 {
                     listaMensajes.Add(message);
                     NotifyPropertyChanged("ListaMensajes");
                 });           
            });

            conexion();
            
        }
        #endregion

        #region metodos
        /// <summary>
        /// Funcion que realiza la conexion al hub
        /// </summary>
        private async void conexion()
        {
            await connection.StartAsync();
        }
        #endregion

        #region Commands
        /// <summary>
        /// metodo que envia el mensaje al chat
        /// </summary>
        public async void enviarExecute()
        {
            mensajeUsuario = new clsMensajeUsuario(usuario, mensaje, grupo);
            await connection.InvokeCoreAsync("SendMessage", args: new[] { mensajeUsuario });
            //usuario = String.Empty;
            mensaje = String.Empty;
            //NotifyPropertyChanged("Usuario");
            NotifyPropertyChanged("Mensaje");
        }

        /// <summary>
        /// metodo que comprueba si el mensaje se puede enviar
        /// </summary>
        /// <returns></returns>
        public bool enviarCanExecute()
        {
            bool canExecute = true;
            if (String.IsNullOrEmpty(mensaje) || String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(grupo))
            {
                canExecute = false;
            }
            return canExecute;
        }

        /// <summary>
        /// metodo que se ejecuta para entrar a un grupo
        /// </summary>
        private async void joinExecute()
        {
            if (!String.IsNullOrEmpty(grupoActual))
            {
                leaveExecute();
            }
            await connection.InvokeCoreAsync("JoinRoom", args: new[] { grupo });
            grupoActual = grupo;
            leaveCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// metodo que comprueba si el boton de unirse se puede pulsar
        /// </summary>
        /// <returns></returns>
        public bool joinCanExecute()
        {
            bool canExecute = true;
            if (String.IsNullOrEmpty(grupo))
            {
                canExecute = false;
            }
            return canExecute;
        }

        /// <summary>
        /// metodo que abandona el grupo en el que se encuentra el user
        /// </summary>
        private async void leaveExecute()
        {
            listaMensajes.Clear();
            await connection.InvokeCoreAsync("LeaveRoom", args: new[] { grupoActual });
            grupoActual = "";
            leaveCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Metodo que comprueba si el boton de abandonar se puede pulsar
        /// </summary>
        /// <returns></returns>
        public bool leaveCanExecute()
        {
            bool canExecute = true;
            if (String.IsNullOrEmpty(grupoActual))
            {
                canExecute = false;
            }
            return canExecute;
        }
        #endregion
    }
}
