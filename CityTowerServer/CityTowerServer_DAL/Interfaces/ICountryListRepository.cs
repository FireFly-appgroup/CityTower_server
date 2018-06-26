using System.Collections.Generic;
using CityTowerServer_DAL.Models;

namespace DataAccessLayer.Interfaces
{
    public interface ICountryListRepository : IRepository<Country_list>
    {
        IEnumerable<Country_list> GetListOfCountry();
    }
}
