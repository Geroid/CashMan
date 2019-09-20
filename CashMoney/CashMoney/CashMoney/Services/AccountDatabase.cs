using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using CashMoney.Models;

namespace CashMoney.Services
{
    public class AccountDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public AccountDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Account>().Wait();
            _database.CreateTableAsync<Transaction>().Wait();
            _database.CreateTableAsync<Category>().Wait();
            _database.CreateTableAsync<Payee>().Wait();
        }

        public Task<List<Account>> GetAccountsAsync()
        {
            return _database.Table<Account>().ToListAsync();
        }

        public Task<List<Transaction>> GetTransactionsAsync()
        {
            return _database.Table<Transaction>().ToListAsync();
        }

        public Task<Transaction> GetTransactionAsync(int id)
        {
            return _database.Table<Transaction>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveTransactionAsync(Transaction transaction)
        {
            return _database.InsertAsync(transaction);
        }

        public Task<List<Category>> GetCategoriesAsync()
        {
            return _database.Table<Category>().ToListAsync();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            return _database.Table<Category>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<Account> GetAccountAsync(int id)
        {
            return _database.Table<Account>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveAccountAsync(Account account)
        {
            return _database.InsertAsync(account);
        }

        public Task<int> UpdateAccountAsync(Account account)
        {
            return _database.UpdateAsync(account);
        }

        public Task<int> DeleteImetAsync(Account account)
        {
            return _database.DeleteAsync(account);
        }
    }
}
