using Microsoft.Maui.Graphics.Text;
using System.Diagnostics;
using System.Numerics;

namespace Ejercicio6UI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón que borra los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton(object sender, EventArgs e)
        {
            nombre.Text = string.Empty;
            apellidos.Text = string.Empty;
            fechaNacimiento.Text = string.Empty;
            labelNombre.Text = string.Empty;
            labelApellidos.Text = string.Empty;
            labelFechaNacimiento.Text = string.Empty;
            labelExito.Text = string.Empty;
        }

        /// <summary>
        /// Botón que comprueba los campos, si fallan mostrará un error en un label,
        /// y si son correctos mostrará un label con éxito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton(object sender, EventArgs e)
        {           
            bool nombreRes = LabelNombre();
            bool apellidoRes = LabelApellido();
            bool fechaRes = LabelFecha();

            if (nombreRes && apellidoRes && fechaRes) 
            {
                labelExito.Text = "Guardado correctamente";
                labelExito.TextColor = Colors.Green;
            }
            else
            {
                labelExito.Text = "";
            }


        }

        /// <summary>
        /// Botón que comprueba los campos y muestra una ventana emergente cuando se pulsa para aceptar o
        /// cancelar el borrado del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DeleteButton(object sender, EventArgs e)
        {
            bool nombreRes = LabelNombre();
            bool apellidoRes = LabelApellido();
            bool fechaRes = LabelFecha();

            if (nombreRes && apellidoRes && fechaRes)
            {
                bool answer = await DisplayAlert("Cuidado!", "Estas a punto de eliminar un usuario", "Eliminar", "Cancelar");
                if (answer) 
                {
                    labelExito.Text = "Eliminado correctamente";
                    labelNombre.TextColor = Colors.Green;
                }
                else
                {
                    labelExito.Text = "No se ha eliminado";
                    labelNombre.TextColor = Colors.Red;
                }
            }
            else
            {
                labelExito.Text = "";
            }
        }

        /// <summary>
        /// Función que compruba si los dias y meses introducidos son correctos
        /// </summary>
        /// <returns></returns>
        private bool ComprobarFecha()
        {
            bool res = false;

            if (!string.IsNullOrEmpty(fechaNacimiento.Text))
            {
                string[] fechaArray = fechaNacimiento.Text.Split('/');

                int dia = int.Parse(fechaArray[0]);

                int year = int.Parse(fechaArray[2]);

                switch (fechaArray[1])
                {
                    case "01":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "02":
                        if (EsBisiesto(year))
                        {
                            if (dia <= 29 && dia > 0)
                            {
                                res = true;
                            }

                        }
                        else 
                        {
                        if (dia <= 28 && dia > 0)
                        {
                            res = true;
                        }
                        }
                        break;
                    case "03":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "04":
                        if (dia <= 30 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "05":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "06":
                        if (dia <= 30 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "07":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "08":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "09":
                        if (dia <= 30 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "10":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "11":
                        if (dia <= 30 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    case "12":
                        if (dia <= 31 && dia > 0)
                        {
                            res = true;
                        }
                        break;
                    default:
                        res = false;
                        break;

                }
            }

            return res;
        }

        /// <summary>
        /// Función que comprueba si un año es bisiesto
        /// </summary>
        /// <param name="year">Año de la fecha de nacimiento</param>
        /// <returns>Devuelve si es un año bisiesto o no</returns>
        public bool EsBisiesto(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        /// <summary>
        /// Comprueba que el campo nombre está lleno
        /// </summary>
        /// <returns>Devuelve si el campo está relleno o no</returns>
        public bool LabelNombre()
        {
            bool res = false;
            if (string.IsNullOrEmpty(nombre.Text))
            {
                labelNombre.Text = "Nombre no válido";
                labelNombre.TextColor = Colors.Red;
            }
            else
            {
                res = true;
                labelNombre.Text = "";
            }
            return res;
        }

        /// <summary>
        /// Comprueba que el campo apellidos está lleno
        /// </summary>
        /// <returns>Devuelve si el campo está relleno o no</returns>
        public bool LabelApellido()
        {
            bool res = false;
            if (string.IsNullOrEmpty(apellidos.Text))
            {
                labelApellidos.Text = "Apellidos no válidos";
                labelApellidos.TextColor = Colors.Red;
            }
            else
            {
                res = true;
                labelApellidos.Text = "";
            }
            return res;
        }

        /// <summary>
        /// Comprueba que el campo fecha está lleno
        /// </summary>
        /// <returns>Devuelve si el campo está relleno o no</returns>
        public bool LabelFecha()
        {
            bool res = false;
            if (!ComprobarFecha())
            {
                labelFechaNacimiento.Text = "Fecha no válida";
                labelFechaNacimiento.TextColor = Colors.Red;
            }
            else
            {
                res = true;
                labelFechaNacimiento.Text = "";
            }
            return res;
        }
    }

}
