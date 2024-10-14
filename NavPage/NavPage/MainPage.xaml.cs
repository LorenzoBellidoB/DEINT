using NavPage.Views;
namespace NavPage
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void IrTabbed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaTabbed());
        }

        

        private void IrPagina4(object sender, EventArgs e)
        {
            ClasePersona persona = new ClasePersona();
            persona.Nombre = nombre.Text.ToString();
            persona.Apellido = apellidos.Text.ToString();
            Navigation.PushAsync(new Pagina4(persona));
        }

        private void IrPagina5(object sender, EventArgs e)
        {
            ClasePersona persona = new ClasePersona();
            persona.Nombre = nombre.Text.ToString();
            persona.Apellido = apellidos.Text.ToString();
            Navigation.PushAsync(new Pagina5{
                BindingContext = persona
            });
        }
    }

}
