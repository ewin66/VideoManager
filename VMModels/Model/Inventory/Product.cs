﻿using System;
using System.Collections.Generic;

namespace VMModels.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Desc { get; set; }
        public int? WarrantyPeriod { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }

        public Product()
        {
            Inventories = new HashSet<Inventory>();
        }
    }
}
