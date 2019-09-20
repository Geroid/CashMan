using System;
using SQLite;

namespace CashMoney.Models
{
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // Дата транзакции
        [NotNull]
        public DateTime When { get; set; }

        // Цена транзакции
        [NotNull]
        public decimal Amount { get; set; }

        public int Account_id { get; set; }

        // Категория расходов
        //public int? CategoryId { get; set; }

        // Покупка
        //public int? PayeeId { get; set; }

        // Добавление средств
        //public int? CreditAccountId { get; set; }

        // Списание средств
        //public int? DebitAccountId { get; set; }
    }
}
