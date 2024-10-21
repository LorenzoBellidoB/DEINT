using System.Collections.ObjectModel;
using Ejercicio5ENT;
using Ejercicio5DAL;

namespace Ejercicio5UI
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

        
    }

}
