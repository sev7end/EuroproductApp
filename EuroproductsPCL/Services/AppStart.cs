using EuroproductsPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroproductsPCL.Services
{
    public class AppStart
    {
        private static AppStart _instance = null;
        private static readonly object root = new object();

        public static AppStart Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (root)
                    {
                        if(_instance == null)
                        {
                            _instance = new AppStart();
                        }
                    }
                }
                return _instance;
            }
        }

        private CategoryServices categoryServices;

        public List<RecipesCategory> recipesCategories;
        public List<ProductsCategory> productsCategories;
        public List<Product> products;
        public List<Recipe> recipes;

        public AppStart()
        {
            categoryServices = new CategoryServices();
        } 
    }
}
