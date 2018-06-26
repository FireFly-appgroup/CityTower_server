using CityTowerServer_DAL.Interfaces;
using CityTowerServer_DAL.Models;
using CityTowerServer_DAL.Repositories;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CityTowerDataBase _context;

        public UnitOfWork(CityTowerDataBase context)
        {
            _context = context;
            CountryList = new CountryListRepository(_context);
            CategoryNewsList = new NewsCategoryListRepository(_context);
        }

        public ICountryListRepository CountryList { get; private set; }
        public INewsCategoryListRepository CategoryNewsList { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
