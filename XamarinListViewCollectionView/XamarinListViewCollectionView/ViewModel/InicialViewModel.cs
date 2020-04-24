using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xamarin.Forms;

namespace XamarinListViewCollectionView.ViewModel
{
    public class InicialViewModel : BaseViewModel
    {
        public Command ListViewCommand { get; }
        public Command CollectionViewCommand { get; }
        public Command SwipeCollectionViewCommand { get; }

        public Command RefreshCollectionViewCommand { get; }

        public InicialViewModel()
        {
            ListViewCommand = new Command(ExecuteListViewCommand);
            CollectionViewCommand = new Command(ExecuteCollectionViewCommand);
            SwipeCollectionViewCommand = new Command(ExecutSwipeCollectionViewCommand);
            RefreshCollectionViewCommand = new Command(ExecutRefreshCollectionViewCommand);
        }

        private async void ExecuteListViewCommand()
        {
            await Navigation.PushAsync<ListViewViewModel>(false);
        }
        private async void ExecuteCollectionViewCommand()
        {
            await Navigation.PushAsync<CollectionViewViewModel>(false);
        }

        private async void ExecutSwipeCollectionViewCommand()
        {
            await Navigation.PushAsync<SwipeCollectionViewViewModel>(false);
        }

        private async void ExecutRefreshCollectionViewCommand()
        {
            await Navigation.PushAsync<RefreshCollectionViewViewModel>(false);
        }
    }
}
