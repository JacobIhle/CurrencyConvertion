using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyWebApi.Repository.Models;

namespace CurrencyWebApi.Repository.Interface
{
    public interface ICurrencyRepository
    {
        CurrencyDbModel Get(int id);
        CurrencyDbModel Add(CurrencyDbModel character);
        CurrencyDbModel Delete(int Id);
    }
}
