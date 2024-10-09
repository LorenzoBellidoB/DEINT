

namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        private Button btn3;

        public MainPage()
        {
            InitializeComponent();          
        }
        
        

        public async void boton2(Object sender, EventArgs e)
        {
            // Crear un nuevo botón
            btn3 = new Button
            {
                Text = "Boton 3",
                BackgroundColor = Colors.Blue,
                BorderColor = Colors.Yellow,
                BorderWidth = 5,
                Margin  = 3,
                WidthRequest = 200,
                HeightRequest = 70,
                FontAttributes = FontAttributes.Bold,
                FontFamily = "Verdana",
                FontSize = 16,
                TextColor = Colors.White
            };

            // Agregar evento Clicked
            btn3.Clicked += btn3Clicked;

            // Agregar el botón al contenedor existente
            VSLBotones.Children.Add(btn3);

            btn2.Clicked -= boton2;
        }

        private void btn3Clicked(object sender, EventArgs e)
        {
            btn1.IsVisible = false;
            btn2.Text = "Crear controles en tiempo de ejecución mola";
            btn2.MaximumWidthRequest = 800;
        }

    }

}
