namespace NavPage.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    private void Pagina3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}