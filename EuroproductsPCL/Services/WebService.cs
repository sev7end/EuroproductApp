using EuroproductsPCL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Services
{
    public class WebService
    {
        private static WebService _instance = null;
        private static readonly object root = new object();
        public static WebService Instance 
        { 
            get
            { 
                if(_instance == null)
                {
                    lock (root)
                    {
                        if(_instance == null)
                        {
                            _instance = new WebService();
                        }
                    }
                }
                return _instance;
            } 
        }

        private HttpClient httpClient;
               
        private string RecipesAPI = "https://europroductcms.azurewebsites.net/api/recipe";
        private string RecipesCategoriesAPI = "https://europroductcms.azurewebsites.net/api/RecipeCategories";
        private string ProductsAPI = "https://europroductcms.azurewebsites.net/api/fetchProducysStepByStep/";//https://europroductcms.azurewebsites.net/api/fetchProducysStepByStep/
        private string ProductsCategoriesAPI = "https://europroductcms.azurewebsites.net/api/productcategory";//requires from/to

        private WebService() 
        { 
            httpClient = new HttpClient();
        }

        private string GetApiDataPath(APIPaths type)
        {
            switch (type)
            {
                case APIPaths.ProductsCategory:
                    return ProductsCategoriesAPI;
                case APIPaths.Recipes:
                    return RecipesAPI;
                case APIPaths.RecipesCategory:
                    return RecipesCategoriesAPI;
                default:
                    return null;
            }
        }

        public async Task<List<T>> GetContentAsync<T>(APIPaths ApiType)
        {
            var content = await httpClient.GetStringAsync(GetApiDataPath(ApiType));
            List<T> Deserialized = JsonConvert.DeserializeObject<List<T>>(content);
            return Deserialized;
        }
        public async Task<List<Product>> GetProductsAsync(int StartPoint, int EndPoint)
        {
            string AdjustedAPI = $"{ProductsAPI}/{StartPoint}/{EndPoint}";
            var content = await httpClient.GetStringAsync(AdjustedAPI);
            List<Product> Deserialized = JsonConvert.DeserializeObject<List<Product>>(content);
            return Deserialized;
        }
    }
}
