using Microsoft.AspNet.Identity.EntityFramework;

namespace CityTowerServer_DAL.Entities
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("CityTowerDataBase")
        {
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}
