using MauiCalculator.Viewmodels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MauiCalculator.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

    }
}