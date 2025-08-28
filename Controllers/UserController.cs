using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Danh sách người dùng";
            ViewBag.Users = new[]
            {
                new { Id = 1, Name = "Nguyễn Văn A", Email = "nguyenvana@email.com", Role = "Admin", Status = "Hoạt động" },
                new { Id = 2, Name = "Trần Thị B", Email = "tranthib@email.com", Role = "User", Status = "Hoạt động" },
                new { Id = 3, Name = "Lê Văn C", Email = "levanc@email.com", Role = "Moderator", Status = "Tạm khóa" },
                new { Id = 4, Name = "Phạm Thị D", Email = "phamthid@email.com", Role = "User", Status = "Hoạt động" },
                new { Id = 5, Name = "Hoàng Văn E", Email = "hoangvane@email.com", Role = "User", Status = "Hoạt động" }
            };
            
            return View();
        }

        public IActionResult Profile(int id)
        {
            var users = new[]
            {
                new { 
                    Id = 1, 
                    Name = "Nguyễn Văn A", 
                    Email = "nguyenvana@email.com", 
                    Role = "Admin", 
                    Status = "Hoạt động",
                    Phone = "0123456789",
                    Address = "123 Đường ABC, Quận 1, TP.HCM",
                    JoinDate = "01/01/2023",
                    LastLogin = "28/08/2024 15:30"
                },
                new { 
                    Id = 2, 
                    Name = "Trần Thị B", 
                    Email = "tranthib@email.com", 
                    Role = "User", 
                    Status = "Hoạt động",
                    Phone = "0987654321",
                    Address = "456 Đường XYZ, Quận 3, TP.HCM",
                    JoinDate = "15/03/2023",
                    LastLogin = "28/08/2024 14:20"
                },
                new { 
                    Id = 3, 
                    Name = "Lê Văn C", 
                    Email = "levanc@email.com", 
                    Role = "Moderator", 
                    Status = "Tạm khóa",
                    Phone = "0369852147",
                    Address = "789 Đường DEF, Quận 5, TP.HCM",
                    JoinDate = "20/06/2023",
                    LastLogin = "25/08/2024 09:15"
                },
                new { 
                    Id = 4, 
                    Name = "Phạm Thị D", 
                    Email = "phamthid@email.com", 
                    Role = "User", 
                    Status = "Hoạt động",
                    Phone = "0523698741",
                    Address = "321 Đường GHI, Quận 7, TP.HCM",
                    JoinDate = "10/09/2023",
                    LastLogin = "28/08/2024 16:45"
                },
                new { 
                    Id = 5, 
                    Name = "Hoàng Văn E", 
                    Email = "hoangvane@email.com", 
                    Role = "User", 
                    Status = "Hoạt động",
                    Phone = "0741852963",
                    Address = "654 Đường JKL, Quận 10, TP.HCM",
                    JoinDate = "05/12/2023",
                    LastLogin = "28/08/2024 13:10"
                }
            };

            var user = users.FirstOrDefault(u => u.Id == id);
            
            if (user == null)
            {
                return NotFound();
            }

            ViewBag.User = user;
            ViewBag.Title = $"Hồ sơ người dùng: {user.Name}";
            
            return View();
        }
    }
}
