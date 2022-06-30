using Clone.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Clone.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}