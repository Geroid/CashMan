using Xamarin.Forms;
using CashMoney.Views;

namespace CashMoney
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("accountentrypage", typeof(AccountEntryPage));
            Routing.RegisterRoute("transactionspage", typeof(TransactionsPage));
            Routing.RegisterRoute("categoriespage", typeof(CategoriesPage));
        }
    }
}
