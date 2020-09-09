using DemoOOP.DI.Interface;
using DemoOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoOOP.Controllers
{
    public class HomeController : Controller
    {
        IProductService productService;
        public HomeController(IProductService _productService)
        {
            productService = _productService;
        }

        public ActionResult Index()
        {
            var listProduct = productService.GetAll();
            return View(listProduct);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Name, string Manufacture, string CreatedBy, bool Active, string Description)
        {
            productService.Create(Name, Manufacture, CreatedBy, Active, Description);
            return RedirectToAction("Index");
        }
    }
}