using System.Web.Http;
using CityTowerServer_BLL.Services;

namespace CityTowerServer_API.Controllers
{
    public class CityTowerAPIController : ApiController
    {
        private ICountryListService CountryListService;

        public CityTowerAPIController(ICountryListService CountryListService)
        {
            this.CountryListService = CountryListService;
        }

        [HttpGet]
        [Route("api/countrylist")]
        public IHttpActionResult Get()
        {
                var CountryList = CountryListService.GetListOfCountry();
                if (CountryList == null)
                    return NotFound();
                else
                return Ok(CountryList);
        }
    }
}
