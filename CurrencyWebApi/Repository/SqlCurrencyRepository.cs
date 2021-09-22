using CurrencyWebApi.Repository.Interface;
using CurrencyWebApi.Repository.Models;

namespace CurrencyWebApi.Repository
{
    public class SqlCurrencyRepository : ICurrencyRepository
    {
        private readonly CurrencyDbContext _context;

        public SqlCurrencyRepository(CurrencyDbContext context)
        {
            _context = context;
        }

        public CurrencyDbModel Get(int id)
        {
            return _context.CurrencyData.Find(id);
        }

        public CurrencyDbModel Add(CurrencyDbModel CurrencyData)
        {
            _context.CurrencyData.Add(CurrencyData);
            _context.SaveChanges();
            return CurrencyData;
        }

        public CurrencyDbModel Delete(int Id)
        {
            var currencyData = _context.CurrencyData.Find(Id);
            _context.Remove(currencyData);
            _context.SaveChanges();
            return currencyData;
        }
    }
}
