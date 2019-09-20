using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashMoney.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashMoney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutAccountPage : ContentPage
    {
        public AboutAccountPage()
        {
            InitializeComponent();
        }
        async private void DeleteAccount(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            await AccountsView.Database.DeleteImetAsync(account);
            await Navigation.PopAsync();
        }

        async void OnIncomeTransactionClicked(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            await Navigation.PushAsync(new IncomeTransactionPage
            {
                BindingContext = account

            });
        }

        async void OnDebitTransactionClicked(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            await Navigation.PushAsync(new DebitTransactionPage
            {
                BindingContext = account
            });
        }
    }
}