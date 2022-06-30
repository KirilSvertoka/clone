using Clone.Models;
using Clone.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatigoriesPage : ContentPage
    {
        private CatigoriesViewModel _viewModel;
        public CatigoriesPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CatigoriesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }


        async void OnItemSelected(Category category)
        {
            if (category == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(CategoryPage)}?{nameof(CategoryViewModel.ItemId)}={category.Id}");
        }
    }
}