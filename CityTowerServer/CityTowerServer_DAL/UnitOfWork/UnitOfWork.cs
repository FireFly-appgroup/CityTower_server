using System;
using CityTowerServer_DAL.Models;
using CityTowerServer_DAL.Repository;

namespace CityTowerServer_DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CityTowerDataBase _context;
        private IGenericRepository<Country_list> countryRepository;
        private IGenericRepository<News_category_list> newsRepository;

        public UnitOfWork()
        {
            this._context = new CityTowerDataBase();
        }

        public IGenericRepository<Country_list> CountryRepository
        {
            get { return this.countryRepository ?? (this.countryRepository = new GenericRepository<Country_list>(_context)); }
        }

        public IGenericRepository<News_category_list> NewsRepository
        {
            get { return this.newsRepository ?? (this.newsRepository = new GenericRepository<News_category_list>(_context)); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
