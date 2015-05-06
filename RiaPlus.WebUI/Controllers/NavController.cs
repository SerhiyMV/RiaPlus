﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RiaPlus.Domain.Abstract;

namespace RiaPlus.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductsRepository repository;

        public NavController(IProductsRepository repository)
        {
            this.repository = repository;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories= repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);


        }
    }
}
