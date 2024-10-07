using Persona;

namespace MauiHolaMundo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnSaludoClicked(object sender, EventArgs e)
        {
            
            string apellidos = await DisplayPromptAsync("Apellidos", "Introduce tus apellidos");
            ClsPersona persona = new ClsPersona();
                       

            if(!String.IsNullOrEmpty(persona.Nombre) && !String.IsNullOrEmpty(persona.Apellidos))
            {
                persona.Nombre = nombre.Text.ToString();
                persona.Apellidos = apellidos;
                saludo.Text += persona.Nombre + " " + apellidos;
                saludo.TextColor = Colors.Black;
            }
            else
            {
                saludo.Text = "Campos incompletos.";
                saludo.TextColor = Colors.Red;
            }
        }
    }

}
