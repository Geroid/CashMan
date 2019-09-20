using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CashMoney.Models;
using CashMoney.Views;

namespace CashMoney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncomeTransactionPage : ContentPage
    {
        public IncomeTransactionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();            
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            account.TotalAmount += decimal.Parse(amountEntry.Text);
            await AccountsView.Database.UpdateAccountAsync(account);
            if (!string.IsNullOrWhiteSpace(amountEntry.Text))
            {
                await AccountsView.Database.SaveTransactionAsync(new Transaction
                {
                    When = DateTime.Now,
                    Amount = decimal.Parse(amountEntry.Text),
                }) ;
                await Navigation.PopAsync();
            }
            
        }
    }
}