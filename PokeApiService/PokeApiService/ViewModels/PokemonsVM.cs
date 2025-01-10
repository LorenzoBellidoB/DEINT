using DAL;
using EjercicioU10.ViewModels.Utilidades;
using ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiService.ViewModels
{
    public class PokemonsVM: INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsPokemon> listadoPokemons;

        private DelegateCommand mostrarListado;

        private int ultimoId = 0;

        private int limite = 20;
        #endregion

        #region Properties
        public List<ClsPokemon> ListadoPokemons
        {
            get
            {
                return listadoPokemons;
            }
            set {
                listadoPokemons = value;
            }
        }

        public DelegateCommand MostrarListado
        {
            get { return mostrarListado; }
        }
        #endregion

        #region Constructores
        public PokemonsVM()
        {
            listadoPokemons = new List<ClsPokemon>();
            mostrarListado = new DelegateCommand(MostrarListadoExecute, CanMostrarListado);
        }
        #endregion

        #region Commands

        private async void MostrarListadoExecute()
        {
            try
            {
                listadoPokemons = await Services.getPokemons(ultimoId, limite);
                limite += 20;

            }catch (Exception ex)
            {

            }
            finally
            {
                NotifyPropertyChanged("ListadoPokemons");
            }
        }

        private bool CanMostrarListado()
        {
            return true;
        }

        #endregion

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new
            PropertyChangedEventArgs(propertyName));

        }
        #endregion   
    }
}
