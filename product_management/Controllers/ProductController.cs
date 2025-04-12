using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace product_management.Controllers
{
   
        // GET: Product
        public class ProductController : Controller
        {
            private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 800 },
            new Product { Id = 2, Name = "Phone", Price = 500 }
        };

         
            public ActionResult ProductList()
            {
                return View(products);
            }

            public ActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Create(Product product)
            {
                product.Id = products.Count + 1;
                products.Add(product);
                return RedirectToAction("Index");
            }

            public ActionResult Edit(int id)
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                return View(product);
            }

            [HttpPost]
            public ActionResult Edit(Product product)
            {
                var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
                if (existingProduct != null)
                {
                    existingProduct.Name = product.Name;
                    existingProduct.Price = product.Price;
                }
                return RedirectToAction("Index");
            }

            public ActionResult Delete(int id)
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                    products.Remove(product);
            TempData["SuccessMessage"] = "Product deleted successfully!";
            return RedirectToAction("ProductList");
            }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
