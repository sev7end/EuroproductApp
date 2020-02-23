using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Models
{
    public class ProductsCategory : ICategory
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Eng")]
        public string NameEng { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }
    }
}
