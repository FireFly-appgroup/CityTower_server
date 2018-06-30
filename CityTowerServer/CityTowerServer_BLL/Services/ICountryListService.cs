using System;
using System.Collections.Generic;
using CityTowerServer_DAL.Models;

namespace CityTowerServer_BLL.Services
{
    public interface ICountryListService : IDisposable
    {
        IEnumerable<Country_list> GetListOfCountry();
    }
}
