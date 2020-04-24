using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinListViewCollectionView.ViewModel
{
   
    class SwipeCollectionViewViewModel : MainViewModel
    {
        public Command PokeballCommand { get; }
        public Command PotionCommand { get; }

        public SwipeCollectionViewViewModel()
        {
            PokeballCommand = new Command(ExecutePokeballCommand);
            PotionCommand = new Command(ExecutePotionCommand);

        }

        private async void ExecutePokeballCommand()
        {
            await Application.Current.MainPage.DisplayAlert("Pokemon Capturado!","Pokeball","OK");
        }

        private async void ExecutePotionCommand()
        {
            await Application.Current.MainPage.DisplayAlert("Pokemon Restaurado!", "Poção", "OK");
        }
    }
}
