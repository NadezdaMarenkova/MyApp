﻿using MyApp.ViewModels;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;


namespace MyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksListPage : ContentPage
    {
        public BooksListPage()
        {
            InitializeComponent();
            BindingContext = new BooksListViewModel()
            {
                Navigation = this.Navigation
            };
        }
    }
}
