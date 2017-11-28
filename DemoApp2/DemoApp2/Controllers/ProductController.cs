using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApp2.Context;
using DemoApp2.Models;

namespace DemoApp2.Controllers
{
    public class ProductController : Controller
    {
        readonly ProductDbContext db=new ProductDbContext();

        public ActionResult GetAllProduct()
        {

            var products = db.Products.ToList();
            //var category = from dbCatagory in db.Catagories
            //    select new
            //    {
            //        dbCatagory.Id
                    
            //    };
            return View(products);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            ViewBag.msg = "saved";
            return View();
        }

        public ActionResult Update(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("GetAllProduct");
        }


      
        public ActionResult Delete(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("GetAllProduct");
        }

    }
}