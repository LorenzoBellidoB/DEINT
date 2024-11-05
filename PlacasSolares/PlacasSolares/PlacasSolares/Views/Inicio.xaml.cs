
using ENT;
using PlacasSolares.ViewModels;

namespace PlacasSolares.Views;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
        BindingContext = new ListadoClienteVM();
        
    }

    private void OnClientSelected(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ClienteDetalle());
    }


}