﻿using System;
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
    public partial class InicialPage : ContentPage
    {
        public InicialPage()
        {
            InitializeComponent();


            this.BindingContext = new InicialViewModel();
        }
    }
}