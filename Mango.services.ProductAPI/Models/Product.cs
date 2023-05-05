﻿namespace Mango.services.ProductAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }    
        public double Price { get; set; } 
        public string Description { get; set; } 
        public string CategoryName { get; set; }  
        public string Imageurl { get; set; } 
    }
}
