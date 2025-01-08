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
        private List<ClsPokemon> listadoPokemons;

        private DelegateCommand mostrarListado;

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

        public PokemonsVM()
        {
            ListadoPokemons = new List<ClsPokemon>();
            mostrarListado = new DelegateCommand(MostrarListado);
        }

        #region Commands



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
