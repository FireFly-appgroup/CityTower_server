using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityTowerServer_DAL.Models;
using DataAccessLayer.Interfaces;

namespace CityTowerServer_DAL.Interfaces
{
    public interface INewsCategoryListRepository : IRepository<News_category_list>
    {
        IEnumerable<News_category_list> ShowCurrentCategoryOfNews(string Category);
    }
}
