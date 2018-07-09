using Microsoft.AspNet.Identity.EntityFramework;

namespace CityTowerServer_DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        public ApplicationUser()
        {
        }
    }
}
