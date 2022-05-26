using Geco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.ViewModels
{
    public class ProductCategoryVM
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
