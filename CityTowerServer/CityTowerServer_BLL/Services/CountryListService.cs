using System.Collections.Generic;
using CityTowerServer_DAL.Models;
using CityTowerServer_DAL.UnitOfWork;

namespace CityTowerServer_BLL.Services
{
    public class CountryListService : ICountryListService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryListService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<Country_list> GetListOfCountry()
        {
            return _unitOfWork.CountryRepository.GetAll();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
