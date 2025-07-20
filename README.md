# UserManagementAPI

A secure, extensible, and modular **ASP.NET Core Web API** for managing user data, built for internal use at **TechHive Solutions**. This project demonstrates the use of **middleware**, **model validation**, and **custom authentication** using token-based security.

---

## 🚀 Features

- ✅ Full CRUD operations for User records
- 🛡️ Token-based authentication middleware
- 🔍 Custom request/response logging middleware
- ❗ Global error-handling middleware for consistent error responses
- 📄 Swagger/OpenAPI integration for interactive API testing
- 🧪 Built-in model validation using `DataAnnotations`

---

## 🧩 Technologies Used

- ASP.NET Core 9.0 (or compatible)
- C#
- Swagger (Swashbuckle)
- Middleware pipeline customization
- In-memory data store (can be swapped with EF Core)
- JSON serialization

---

## 📦 Folder Structure

UserManagementAPI/
│
├── Controllers/
│ └── UsersController.cs # Main API controller for user CRUD
│
├── Middleware/
│ ├── ErrorHandlingMiddleware.cs
│ ├── RequestResponseLoggingMiddleware.cs
│ ├── TokenAuthenticationMiddleware.cs
│ └── MiddlewareExtensions.cs # Extension methods to register middleware
│
├── Models/
│ └── User.cs # User model with validation
│
├── Properties/
│ └── launchSettings.json
│
├── Program.cs # App configuration and middleware pipeline
├── appsettings.json
└── UserManagementAPI.csproj
