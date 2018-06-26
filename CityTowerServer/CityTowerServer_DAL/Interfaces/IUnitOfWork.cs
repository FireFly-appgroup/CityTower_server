using System;
using CityTowerServer_DAL.Interfaces;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryListRepository CountryList { get; }
        INewsCategoryListRepository CategoryNewsList { get; }
        int Complete();
    }
}
