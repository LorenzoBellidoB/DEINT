using ListadoPersonaDAL;
using ListadoPersonaENT;

namespace ListadoPersonaMaui.Views
{

        public partial class MainPage : ContentPage
        {
            List<Persona> listado = new List<Persona>();
            public MainPage()
            {
                InitializeComponent();
                listado = ListadoPersona.GetListadoCompleto();
                PersonListView.ItemsSource = listado;
            }

            private void ImageButton_Clicked(object sender, EventArgs e)
            {

            }
        }
    }
