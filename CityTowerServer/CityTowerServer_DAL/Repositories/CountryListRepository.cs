using System.Collections.Generic;
using System.Linq;
using CityTowerServer_DAL.Models;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repositories
{
    public class CountryListRepository : Repository<Country_list>, ICountryListRepository
    {
        public CountryListRepository(CityTowerDataBase context) : base(context)
        {
        }

        public IEnumerable<Country_list> GetListOfCountry()
        {
            return CityTowerDB.Country_list.ToList();
        }

        public CityTowerDataBase CityTowerDB
        {
            get { return Context as CityTowerDataBase; }
        }
    }
}
