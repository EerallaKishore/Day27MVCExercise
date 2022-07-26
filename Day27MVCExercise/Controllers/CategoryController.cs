using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day27MVCExercise.Models;

namespace Day27MVCExercise.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var category = GetCategories();
            return View();
        }
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id=1, Name="AMD Ryzen 5"},
                new Category { Id=2, Name="Water Bottle"},
               
            };
        }

    }
}