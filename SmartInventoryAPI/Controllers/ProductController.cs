using Microsoft.AspNetCore.Mvc;
using SmartInventoryAPI.Models;

namespace SmartInventoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        // creating a list of product as per model class

        static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000, Quantity = 10 },
            new Product { Id = 2, Name = "Smartphone", Price = 500, Quantity = 20 },
            new Product { Id = 3, Name = "Headphones", Price = 100, Quantity = 30 }
        };

        // GET: api/product
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return products;
        }

        // GET: api/product/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // POST: api/product
        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1; // Auto-increment ID
            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/product/{id}
        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            products.Remove(existingProduct);
            product.Id = id;
            products.Add(product);
            return product;
        }

        // DELETE: api/product/{id}
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products.Remove(product);
            return product;
        }
    }
}