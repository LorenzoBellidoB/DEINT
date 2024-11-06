
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


    private void OnButtonInicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Inicio());
    }
    private void OnButtonInforme(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ClienteDetalle());
    }
    private async void OnButtonGps(object sender, EventArgs e)
    {
        var location = "https://www.google.com/maps?q=37.568531, -5.428536";
        await Launcher.OpenAsync(new Uri(location));
    }
    private async void OnButtonCamara(object sender, EventArgs e)
    {
        try
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
            }
        }
        catch (FeatureNotSupportedException)
        {
            await DisplayAlert("Error", "La cámara no está soportada en este dispositivo.", "OK");
        }
        catch (PermissionException)
        {
            await DisplayAlert("Permiso denegado", "Permiso de acceso a la cámara denegado.", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
        }
    }


    private void OnClientSelected(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ClienteDetalle());
    }





}