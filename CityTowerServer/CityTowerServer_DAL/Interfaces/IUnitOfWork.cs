using System;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryListRepository CountryList { get; }
        int Complete();
    }
}
