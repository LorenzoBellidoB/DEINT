namespace MauiHolaMundo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async Task Prompt()
        {
            string result = await DisplayPromptAsync("", "Introduce tus apellidos");
        }

        private void OnSaludoClicked(object sender, EventArgs e)
        {
            result = Prompt();
            saludo.Text = saludo.Text + nombre.Text + result;
        }
    }

}
