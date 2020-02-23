using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Models
{
    public class Product
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ShortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("LongDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("Name_Eng")]
        public string NameEng { get; set; }

        [JsonProperty("ShortDescription_Eng")]
        public string ShortDescriptionEng { get; set; }

        [JsonProperty("LongDescription_Eng")]
        public string LongDescriptionEng { get; set; }

        [JsonProperty("ProductCategory")]
        public ProductsCategory ProductCategory { get; set; }

        [JsonProperty("MainImageUrl")]
        public string MainImageUrl { get; set; }

        [JsonProperty("CoverImages")]
        public List<string> CoverImages { get; set; }

        [JsonProperty("OtherCategories")]
        public List<ProductsCategory> OtherCategories { get; set; }
    }
}
