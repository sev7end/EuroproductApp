using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroproductsPCL.Models
{
    public interface ICategory
    {
        
        long Id { get; set; }

        string Name { get; set; }

        string NameEng { get; set; }

        //string ImageUrl { get; set; }
    }
}
