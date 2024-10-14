namespace NavPage.Views;

public partial class Pagina4 : ContentPage
{
	public Pagina4(ClasePersona persona)
	{
		InitializeComponent();
		Label nombre = new Label { Text = persona.Nombre.ToString() };
        Label apellido = new Label { Text = persona.Apellido.ToString() };
        StackLayout stackLayout = new StackLayout
        {
            Children = { nombre, apellido }
        };

        Content = stackLayout;
    }
}