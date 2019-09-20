using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using CashMoney.Models;
using System.Collections.Generic;
using CashMoney.Services;

namespace CashMoney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountsView : ContentPage
    {

        static AccountDatabase database;

        public static AccountDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new AccountDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Accounts.db3"));
                }
                return database;
            }
        }

        public AccountsView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await AccountsView.Database.GetAccountsAsync();
        }

        async void OnAccountAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountEntryPage
            {
                BindingContext = new Account()
            });
        }


        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Account selectedItem = e.SelectedItem as Account;
            await Navigation.PushAsync(new AboutAccountPage
            {
                BindingContext = selectedItem
    });
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Account tappedItem = e.Item as Account; 
        }

    }
}