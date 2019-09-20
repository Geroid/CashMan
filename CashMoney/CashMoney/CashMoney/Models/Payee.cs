using SQLite;

namespace CashMoney.Models
{
    public class Payee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [NotNull]
        public string Name { get; set; }
    }
}
