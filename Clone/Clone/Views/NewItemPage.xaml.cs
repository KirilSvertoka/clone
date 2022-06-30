﻿using Clone.Models;
using Clone.ViewModels;
using Clone.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace Clone.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        private NewItemViewModel _viewModel;
        private IEnumerable<Category> categories;

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = _viewModel= new NewItemViewModel();
            LoadCategories();

        }

        async Task LoadCategories()
        {

            try
            {
            
                categories = await _viewModel.DataStoreCatigories.GetItemsAsync(true) as IEnumerable<Category>;

                List<string> categoriesTitles = new List<string>();
                foreach (var category in categories)
                {
                    categoriesTitles.Add(category.Title);
                }
                PickerCategory.ItemsSource = categoriesTitles; //оно не работает(((
                if (categoriesTitles.Count > 0)
                    PickerCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatePickerDate_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            _viewModel.Date = e.NewDate.ToShortDateString();

        }
    }
}