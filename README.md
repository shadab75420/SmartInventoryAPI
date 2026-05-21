# SmartInventoryAPI

SmartInventoryAPI is a simple ASP.NET Core Web API project developed to perform basic CRUD (Create, Read, Update, Delete) operations for product inventory management. The project demonstrates how to build RESTful APIs using ASP.NET Core controllers and in-memory data storage.

------------------------------------------------------------

## Features

- Get all products
- Get product by ID
- Add new product
- Update existing product
- Delete product
- Swagger UI integration for API testing
- RESTful API architecture
- In-memory product storage using List<Product>

------------------------------------------------------------

## Technologies Used

- ASP.NET Core Web API
- C#
- Swagger / OpenAPI
- Visual Studio 2022
- .NET 8 / .NET 9

------------------------------------------------------------

## Project Structure

```text
SmartInventoryAPI
│
├── Controllers
│   └── ProductController.cs
│
├── Models
│   └── Product.cs
│
├── Program.cs
│
├── appsettings.json
│
└── SmartInventoryAPI.csproj
```

------------------------------------------------------------

## Product Model

The Product model contains:

- Id
- Name
- Price
- Quantity

------------------------------------------------------------

## API Endpoints

### Get All Products

```http
GET /api/product
```

Returns all available products.

---

### Get Product By ID

```http
GET /api/product/{id}
```

Returns a specific product by ID.

---

### Create Product

```http
POST /api/product
```

Adds a new product.

Example JSON:

```json
{
  "id": 4,
  "name": "Keyboard",
  "price": 500,
  "quantity": 20
}
```

---

### Update Product

```http
PUT /api/product/{id}
```

Updates an existing product.

---

### Delete Product

```http
DELETE /api/product/{id}
```

Deletes a product by ID.

------------------------------------------------------------

## Swagger Integration

Swagger UI is enabled for API documentation and testing.

Swagger URL:

```text
https://localhost:xxxx/swagger
```

Replace `xxxx` with your project port number.

------------------------------------------------------------

## How to Run the Project

### Step 1: Clone the Repository

```bash
git clone <repository-url>
```

---

### Step 2: Open in Visual Studio

Open the `.sln` file using Visual Studio 2022.

---

### Step 3: Install Swagger Package

Open Package Manager Console and run:

```powershell
Install-Package Swashbuckle.AspNetCore
```

---

### Step 4: Build the Project

```text
Build → Rebuild Solution
```

---

### Step 5: Run the Application

Press:

```text
Ctrl + F5
```

or click the Run button in Visual Studio.

---

### Step 6: Open Swagger

Navigate to:

```text
https://localhost:xxxx/swagger
```

------------------------------------------------------------

## Sample Response

```json
[
  {
    "id": 1,
    "name": "Product 1",
    "price": 10,
    "quantity": 100
  },
  {
    "id": 2,
    "name": "Product 2",
    "price": 20,
    "quantity": 200
  }
]
```

------------------------------------------------------------

## Notes

- This project uses in-memory data storage.
- Data will reset whenever the application restarts.
- No database integration is included currently.
- Suitable for beginners learning ASP.NET Core Web API development.

------------------------------------------------------------

## Future Improvements

- SQL Server integration
- Entity Framework Core
- Authentication and Authorization
- Repository Pattern
- Service Layer Architecture
- DTO Implementation
- Validation
- Logging and Exception Handling

------------------------------------------------------------

## Conclusion

SmartInventoryAPI is a beginner-friendly ASP.NET Core Web API project that demonstrates REST API development with CRUD operations and Swagger integration. It can be extended further into a complete inventory management system.
