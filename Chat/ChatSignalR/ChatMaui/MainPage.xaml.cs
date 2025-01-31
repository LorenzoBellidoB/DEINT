using Microsoft.AspNetCore.SignalR.Client;
using Models;
using System.Collections.ObjectModel;

namespace ChatMaui
{
    public partial class MainPage : ContentPage
    {
        /*public readonly HubConnection connection;
        public ObservableCollection<clsMensajeUsuario> mensajes = new ObservableCollection<clsMensajeUsuario>();*/
        public MainPage()
        {
            InitializeComponent();
            /*BindingContext = this;
            ListaMensajes.ItemsSource = mensajes;

            connection = new HubConnectionBuilder().WithUrl("http://localhost:5250/chathub").Build();

            connection.On<clsMensajeUsuario>("ReceiveMessage", (message) =>
            {
                mensajes.Add(message);
            });

            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                await connection.StartAsync());
            });*/
        }
        /*public async void OnSendClicked(object sender, EventArgs e)
        {
            clsMensajeUsuario mensaje = new clsMensajeUsuario();
            mensaje.NombreUsuario = username.Text;
            mensaje.MensajeUsuario = message.Text;
            await connection.InvokeCoreAsync("SendMessage", args: new[] { mensaje });
           // mensajes.Add(mensaje);

            username.Text = String.Empty;
            message.Text = String.Empty;
        }*/
    }

}
