using Clone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clone.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryPage : ContentPage
	{
		private CategoryViewModel _categoryViewModel;
		public CategoryPage ()
		{
			InitializeComponent ();
            CategoryViewModel categoryViewModel = new
                            CategoryViewModel();
            BindingContext = _categoryViewModel = categoryViewModel;
		}
	}
}