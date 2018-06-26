using System;
using System.Collections.Generic;
using CityTowerServer_BAL.Interfaces;
using CityTowerServer_DAL.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;

namespace CityTowerServer_BAL.Services
{
    public class NewsCategoryService : INewsCategoryService, IDisposable
    {
        private IUnitOfWork unitOfWork;
        public NewsCategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<News_category_list> GetCurrentNews()
        {
            var unitOfWork = new UnitOfWork(new CityTowerDataBase());
            return unitOfWork.CategoryNewsList.ShowCurrentCategoryOfNews("City");
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    unitOfWork.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
