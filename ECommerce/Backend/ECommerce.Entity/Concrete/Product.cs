﻿using ECommerce.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();
    }
}


