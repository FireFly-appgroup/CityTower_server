using System.Collections.Generic;
using System.Linq;
using CityTowerServer_DAL.Interfaces;
using CityTowerServer_DAL.Models;
using DataAccessLayer.Repositories;

namespace CityTowerServer_DAL.Repositories
{
    public class NewsCategoryListRepository : Repository<News_category_list>, INewsCategoryListRepository
    {
        public NewsCategoryListRepository(CityTowerDataBase context) : base(context)
        {
        }

        public IEnumerable<News_category_list> ShowCurrentCategoryOfNews(string Category)
        {
            return CityTowerDB.News_category_list.Where(t=>t.Category == Category).ToList();
        }

        public CityTowerDataBase CityTowerDB
        {
            get { return Context as CityTowerDataBase; }
        }
    }
}
