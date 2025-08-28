# ASP.NET Core MVC Application

Ứng dụng ASP.NET Core MVC với 2 controller chính: ProductController và UserController.

## Tính năng

### ProductController
- **Index Action**: Hiển thị danh sách sản phẩm với thông tin cơ bản
- **Details Action**: Hiển thị chi tiết sản phẩm theo ID

### UserController  
- **Index Action**: Hiển thị danh sách người dùng với thống kê
- **Profile Action**: Hiển thị chi tiết hồ sơ người dùng theo ID

## Cấu trúc Project

```
MyAspNetCoreApp/
├── Controllers/
│   ├── HomeController.cs
│   ├── ProductController.cs
│   └── UserController.cs
├── Views/
│   ├── Home/
│   ├── Product/
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   └── User/
│       ├── Index.cshtml
│       └── Profile.cshtml
├── Models/
├── wwwroot/
└── Program.cs
```

## Cách chạy ứng dụng

1. Đảm bảo đã cài đặt .NET 8.0 SDK
2. Clone repository:
   ```bash
   git clone https://github.com/minhbidodangcode/BaitapLTW.git
   cd MyAspNetCoreApp
   ```
3. Chạy ứng dụng:
   ```bash
   dotnet run
   ```
4. Mở trình duyệt và truy cập: `http://localhost:5000`

## Các trang chính

- **Trang chủ**: `http://localhost:5000/`
- **Danh sách sản phẩm**: `http://localhost:5000/Product`
- **Chi tiết sản phẩm**: `http://localhost:5000/Product/Details/{id}`
- **Danh sách người dùng**: `http://localhost:5000/User`
- **Hồ sơ người dùng**: `http://localhost:5000/User/Profile/{id}`

## Công nghệ sử dụng

- ASP.NET Core 8.0
- MVC Pattern
- Bootstrap 5
- Font Awesome Icons
- Razor Views

## Tác giả

Hà Bình Minh - 231230841
