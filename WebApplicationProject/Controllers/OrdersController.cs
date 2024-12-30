﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class OrdersController : Controller
    {
        // GET: OrdersController
        public IActionResult  Index()
        {
            var ordersJson = System.IO.File.ReadAllText("Data/orders.json");
            var orders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(ordersJson);
            var orderSummary = orders.Select(order => new
            {
                OrderId = order.Id,
                NetPrice = order.Items.Sum(item => item.Quantity * item.Product.Price),
            });
        }

        // GET: OrdersController/Details/5
        public IActionResult  Details(int id)
        {
            return View();
        }

        // GET: OrdersController/Create
        public IActionResult  Create()
        {
            return View();
        }

        // POST: OrdersController/Create
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

        // GET: OrdersController/Edit/5
        public IActionResult  Edit(int id)
        {
            return View();
        }

        // POST: OrdersController/Edit/5
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

        // GET: OrdersController/Delete/5
        public IActionResult  Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
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
