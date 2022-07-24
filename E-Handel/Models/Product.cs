using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Handel.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public ProductType ProductType { get; set; }// Nvigation property


    }
}
