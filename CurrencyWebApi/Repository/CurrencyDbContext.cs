using CurrencyWebApi.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CurrencyWebApi.Repository
{
    public class CurrencyDbContext : DbContext
    {
        public CurrencyDbContext(DbContextOptions<CurrencyDbContext> options) : base(options)
        {
        }

        public DbSet<CurrencyDbModel> CurrencyData { get; set; }
    }
}
