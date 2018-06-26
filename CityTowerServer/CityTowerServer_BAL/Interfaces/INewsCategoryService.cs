using System;
using System.Collections.Generic;
using System.Text;
using CityTowerServer_DAL.Models;

namespace CityTowerServer_BAL.Interfaces
{
    public interface INewsCategoryService
    {
        IEnumerable<News_category_list> GetCurrentNews();
    }
}
