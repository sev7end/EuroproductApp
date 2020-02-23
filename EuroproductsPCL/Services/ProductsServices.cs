using EuroproductsPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Services
{
    public class ProductsServices
    {
        public async Task<List<Product>> GetProductsAsync(int FromObj,int ToObj)//612
        {
            var _Products = await WebService.Instance.GetProductsAsync(FromObj,ToObj);
            return _Products;
        }

        
    }
}
