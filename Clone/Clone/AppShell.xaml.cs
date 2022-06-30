﻿using Clone.ViewModels;
using Clone.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Clone
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(CategoryPage), typeof(CategoryPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Main/AboutPage");
        }
    }
}
