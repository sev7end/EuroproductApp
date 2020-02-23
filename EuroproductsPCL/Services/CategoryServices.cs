using EuroproductsPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Services
{
    public class CategoryServices
    {
        public CategoryServices()
        {

        }
        public async Task<List<RecipesCategory>> GetRecipesCategoriesAsync()
        {
            var _RecipesCategory = await WebService.Instance.GetContentAsync<RecipesCategory>(APIPaths.RecipesCategory);
            return _RecipesCategory;
        }

        public async Task<List<ProductsCategory>> GetProductsCategoriesAsync()
        {
            var _ProductsCategory = await WebService.Instance.GetContentAsync<ProductsCategory>(APIPaths.ProductsCategory);
            return _ProductsCategory;
        }

    }
}
