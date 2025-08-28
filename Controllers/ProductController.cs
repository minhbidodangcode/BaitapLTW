using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Danh sách sản phẩm";
            ViewBag.Products = new[]
            {
                new { Id = 1, Name = "Laptop Dell", Price = 15000000, Category = "Điện tử" },
                new { Id = 2, Name = "iPhone 15", Price = 25000000, Category = "Điện thoại" },
                new { Id = 3, Name = "Samsung TV", Price = 12000000, Category = "Điện tử" },
                new { Id = 4, Name = "MacBook Pro", Price = 35000000, Category = "Điện tử" }
            };
            
            return View();
        }

        public IActionResult Details(int id)
        {
            var products = new[]
            {
                new { Id = 1, Name = "Laptop Dell", Price = 15000000, Category = "Điện tử", Description = "Laptop Dell Inspiron với hiệu suất cao, phù hợp cho công việc và học tập." },
                new { Id = 2, Name = "iPhone 15", Price = 25000000, Category = "Điện thoại", Description = "iPhone 15 mới nhất với camera chất lượng cao và hiệu suất mạnh mẽ." },
                new { Id = 3, Name = "Samsung TV", Price = 12000000, Category = "Điện tử", Description = "Smart TV Samsung 55 inch với độ phân giải 4K và nhiều tính năng thông minh." },
                new { Id = 4, Name = "MacBook Pro", Price = 35000000, Category = "Điện tử", Description = "MacBook Pro với chip M2, hiệu suất đỉnh cao cho các tác vụ chuyên nghiệp." }
            };

            var product = products.FirstOrDefault(p => p.Id == id);
            
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Product = product;
            ViewBag.Title = $"Chi tiết sản phẩm: {product.Name}";
            
            return View();
        }
    }
}
