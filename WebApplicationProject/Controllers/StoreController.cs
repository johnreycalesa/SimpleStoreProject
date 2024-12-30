using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class StoreController : Controller
    {
        // GET: StoreController
        public IActionResult  Index()
        {
            var productsJson = System.IO.File.ReadAllText("Data/products.json");
            var products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(productsJson);
            return View(products);
        }

        // GET: StoreController/Details/5
        public IActionResult  Details(int id)
        {
            return View();
        }

        // GET: StoreController/Create
        public IActionResult  Create()
        {
            return View();
        }

        // POST: StoreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult  Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreController/Edit/5
        public IActionResult  Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult  Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreController/Delete/5
        public IActionResult  Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult  Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
