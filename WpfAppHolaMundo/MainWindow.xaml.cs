using BibliotecaClases;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppHolaMundo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsPersona persona = new ClsPersona();
            if(txtNombre.Text != null && !txtNombre.Text.Equals(""))
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Fecha = fecha.SelectedDate;
                MessageBox.Show("Hola, " + persona.Nombre);
            }
            else
            {
                mError.Content = "Error, no hay nadie";
            }
                                  
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}