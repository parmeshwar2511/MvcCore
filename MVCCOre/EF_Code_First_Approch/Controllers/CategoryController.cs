using EF_Code_First_Approch.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Code_First_Approch.Controllers
{
    public class CategoryController : Controller
    {
        ProductDbContext _context;

        public CategoryController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Category> categories = _context.categories.ToList();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        { 
          _context.categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? id)
        { 
            var category = _context.categories.Find(id);
            return View(category);   
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        { 
           var value = _context.categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category != null)
            {

                var categoryDb = _context.categories.Find(category.Id);

               categoryDb.Number = category.Number;
                categoryDb.Email = category.Email;
                categoryDb.Name = category.Name;

                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(category);

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _context.categories.Find(id);
            return View();
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeleteConfirmed(int? id)
        {
            var value = _context.categories.Find(id);
            _context.categories.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
