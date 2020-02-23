using EuroproductsPCL.Models;
using EuroproductsPCL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroproductApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void PerformTest(this Control target, Action action)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CategoryServices categoryServices = new CategoryServices();
            ProductsServices productsServices = new ProductsServices();
            RecipesServices recipesServices = new RecipesServices();
            var mainPage = new MainPage();

            Task.Run(async () =>
            {
                AppStart.Instance.productsCategories = await categoryServices.GetProductsCategoriesAsync();
                AppStart.Instance.recipesCategories = await categoryServices.GetRecipesCategoriesAsync();
                AppStart.Instance.products = await productsServices.GetProductsAsync(1, 100);
                AppStart.Instance.recipes = await recipesServices.GetRecipesAsync();

                mainPage.PerformTest(() => mainPage.CreateCategories());
            });
         
            Application.Run(mainPage);
        }
    }
}
