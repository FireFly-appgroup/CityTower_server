using System;
using CityTowerServer_DAL.Models;
using CityTowerServer_DAL.Repository;

namespace CityTowerServer_DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country_list> CountryRepository { get; }
        IGenericRepository<News_category_list> NewsRepository { get; }
        void Save();
    }
}
