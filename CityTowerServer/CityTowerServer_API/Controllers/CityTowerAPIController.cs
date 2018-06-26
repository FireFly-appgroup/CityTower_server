using DataAccessLayer.Repositories;
using System.Web.Http;
using CityTowerServer_DAL.Models;

namespace CityTowerServer_API.Controllers
{
    public class CityTowerAPIController : ApiController
    {
        [HttpGet]
        [Route("api/countrylist")]
        public IHttpActionResult Get()
        {
            using (var unitOfWork = new UnitOfWork(new CityTowerDataBase()))
            {
                var CountryList = unitOfWork.CountryList;
                return Ok(CountryList);
            }
        }
    }
}
