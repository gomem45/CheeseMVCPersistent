using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            var allCategories = context.Categories.ToList();
            
            return View(allCategories);
        }

        public IActionResult Add()
        {
            AddCategoryViewModel newCheese = new AddCategoryViewModel();

            return View(newCheese);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel newCheese)
        {
            if (ModelState.IsValid)
            {
                CheeseCategory newCategory = new CheeseCategory
                {
                    Name = newCheese.Name
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();

                return Redirect("/Category");
            }

            return View(newCheese);
        }


    }
}
