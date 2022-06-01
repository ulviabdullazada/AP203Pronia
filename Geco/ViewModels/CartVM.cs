using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.ViewModels
{
    public class CartVM
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsActive { get; set; }
    }
}
