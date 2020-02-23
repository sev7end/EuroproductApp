using EuroproductsPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Services
{
    public class RecipesServices
    {
        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var _Recipes = await WebService.Instance.GetContentAsync<Recipe>(APIPaths.Recipes);
            return _Recipes;
        }
    }
}
