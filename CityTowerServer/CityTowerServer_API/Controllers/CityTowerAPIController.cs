using DataAccessLayer.Repositories;
using System.Web.Http;
using CityTowerServer_API.Interfaces;
using CityTowerServer_DAL.Models;

namespace CityTowerServer_API.Controllers
{
    public class CityTowerAPIController : ApiController
    {
        [HttpGet]
        [Route("api/countrylist")]
        public IHttpActionResult Get()
        {
                var UnitOfWork = new UnitOfWork(new CityTowerDataBase());
                var CountryList = UnitOfWork.CountryList.GetListOfCountry();
                if (CountryList == null)
                    return NotFound();
                else
                return Ok(CountryList);
        }
    }
}
