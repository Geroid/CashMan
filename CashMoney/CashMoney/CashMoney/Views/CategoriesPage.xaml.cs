using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CashMoney.Models;

namespace CashMoney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await AccountsView.Database.GetCategoriesAsync();

        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Category selectedItem = e.SelectedItem as Category;
            await Navigation.PushAsync(new AboutCategoryPage
            {
                BindingContext = selectedItem
            });
        }
    }
}