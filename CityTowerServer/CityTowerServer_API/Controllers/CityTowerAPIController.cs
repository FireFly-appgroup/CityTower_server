using DataAccessLayer.Repositories;
using System.Web.Http;
using CityTowerServer_DAL.Models;
using DataAccessLayer.Interfaces;

namespace CityTowerServer_API.Controllers
{
    public class CityTowerAPIController : ApiController
    {
        private ICountryListRepository CountryListRepository;

        public CityTowerAPIController()
        {
            this.CountryListRepository = new CountryListRepository(new CityTowerDataBase());
        }

        public CityTowerAPIController(ICountryListRepository CountryListRepository)
        {
            this.CountryListRepository = CountryListRepository;
        }

        [HttpGet]
        [Route("api/countrylist")]
        public IHttpActionResult Get()
        {
                var CountryList = CountryListRepository.GetListOfCountry();
                if (CountryList == null)
                    return NotFound();
                else
                return Ok(CountryList);
        }
    }
}
