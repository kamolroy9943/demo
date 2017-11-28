using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Catagory> Catagories { get; set; }
    }
}