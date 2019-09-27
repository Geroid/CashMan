using SQLite;

namespace CashMoney.Models
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public decimal TotalAmount { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
