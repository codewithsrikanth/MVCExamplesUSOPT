using System.Collections.Generic;
using System.Web.Mvc;
using WebLayoutAndPartialViews.Models;

namespace WebLayoutAndPartialViews.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            throw new System.Exception("This is from product Index");
            //List<Product> products = new List<Product>()
            //{
            //    new Product(){ProductId=1,Name="Mobile",Category="Electronics",Price=25000,Description="Test1"},
            //    new Product(){ProductId=1,Name="Mobile",Category="Electronics",Price=25000,Description="Test1"},
            //    new Product(){ProductId=1,Name="Mobile",Category="Electronics",Price=25000,Description="Test1"},
            //    new Product(){ProductId=1,Name="Mobile",Category="Electronics",Price=25000,Description="Test1"},
            //    new Product(){ProductId=1,Name="Mobile",Category="Electronics",Price=25000,Description="Test1"},
            //    new Product(){ProductId=1,Name="Mobile",Category="Electronics",Price=25000,Description="Test1"}
            //};
            //return View(products);
        }
    }
}