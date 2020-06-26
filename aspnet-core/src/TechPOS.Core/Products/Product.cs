using System;
using System.Collections.Generic;
using System.Text;

namespace TechPOS.Products
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
