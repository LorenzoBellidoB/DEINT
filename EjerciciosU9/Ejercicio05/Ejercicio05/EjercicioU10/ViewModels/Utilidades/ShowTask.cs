using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioU10.ViewModels.Utilidades
{
    public interface IMessageService
    {
        Task<bool> MostrarConfirmacion(string mensaje, string titulo);
    }

    public class ShowTask : IMessageService
    {
        public Task<bool> MostrarConfirmacion(string mensaje, string titulo)
        {
            throw new NotImplementedException();
        }

        public static async Task<bool> MostrarConfirmacionAsync(string mensaje, string titulo)
        {
            return await Application.Current.MainPage.DisplayAlert(titulo, mensaje, "Aceptar", "Cancelar");
        }
    }
}
