using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp2.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string CatagoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}