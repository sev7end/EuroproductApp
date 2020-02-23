using EuroproductsPCL.Models;
using EuroproductsPCL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEuroproducts
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ProductsServices services = new ProductsServices();

            List<Product> prods = await services.GetProductsAsync(1, 3500);
            Console.ReadKey();
        }
    }
}
