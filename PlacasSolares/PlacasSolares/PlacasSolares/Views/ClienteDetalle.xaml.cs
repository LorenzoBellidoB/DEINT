using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Media;
using Microsoft.Maui.Controls;

namespace PlacasSolares.Views
{
    public partial class ClienteDetalle : ContentPage
    {
        public ClienteDetalle()
        {
            InitializeComponent();

        }


        private async void OnMapButtonClicked(object sender, EventArgs e)
        {
            var location = "https://www.google.com/maps?q=37.568531, -5.428536"; 
            await Launcher.OpenAsync(new Uri(location));
        }

        
        private async void OnCameraButtonClicked(object sender, EventArgs e)
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
    }
}
