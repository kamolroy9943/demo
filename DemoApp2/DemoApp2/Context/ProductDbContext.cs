using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DemoApp2.Models;

namespace DemoApp2.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext():base("DefaultConnection"){}
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    }
}