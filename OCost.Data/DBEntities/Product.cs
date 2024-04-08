﻿using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Product
    {
        public int Id { get; set; }
        public string NameEn { get; set; } = string.Empty;
        public string NameAr { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageURL { get; set; }
        public Currency? UnitPrice { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();
        public List<ProductCategory> ProductCategories { get; set; }  = new List<ProductCategory>();
    }
}