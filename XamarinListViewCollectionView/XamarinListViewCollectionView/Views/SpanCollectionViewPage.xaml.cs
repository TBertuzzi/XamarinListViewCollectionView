using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinListViewCollectionView.ViewModel;

namespace XamarinListViewCollectionView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpanCollectionViewPage : ContentPage
    {
        public SpanCollectionViewPage()
        {
            InitializeComponent();

            this.BindingContext = new SpanCollectionViewViewModel();

        }
    }
}