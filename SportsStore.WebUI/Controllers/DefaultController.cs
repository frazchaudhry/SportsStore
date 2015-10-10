using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private IProductsRepository repository;

        public DefaultController(IProductsRepository repository)
        {
            this.repository = repository;
        }

        // GET: Default
        public ActionResult Index()
        {
            var products = repository.Products.ToList();
            return View(products);
        }
    }
}