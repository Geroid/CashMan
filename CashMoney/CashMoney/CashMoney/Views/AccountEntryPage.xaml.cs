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
    public partial class AccountEntryPage : ContentPage
    {
        public AccountEntryPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(amountEntry.Text))
            {
                await AccountsView.Database.SaveAccountAsync(new Account
                {
                    Name = nameEntry.Text,
                    TotalAmount = decimal.Parse(amountEntry.Text)
                });

                nameEntry.Text = amountEntry.Text = string.Empty;
                await Navigation.PopAsync();
            }
        }
    }
}