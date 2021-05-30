using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeriatRFinal3.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string SellerName { get; set; }
        public string Country { get; set; }
        public decimal Rate { get; set; }
        public decimal BuyingPrice { get; set; }
        public string BrandName { get; set; }

    }
}
