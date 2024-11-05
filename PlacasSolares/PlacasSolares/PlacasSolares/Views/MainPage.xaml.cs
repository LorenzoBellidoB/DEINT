using PlacasSolares.Views;

namespace PlacasSolares
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void BotonLogin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inicio());
        }

    }

}
