# Freaky Fashion API

A RESTful Web API built with ASP.NET Core and Entity Framework Core for the e-commerce platform Freaky Fashion.

## Tech Stack

- ASP.NET Core (.NET 10)
- Entity Framework Core
- SQL Server
- Azure App Service
- Azure SQL Database
- Azure Pipelines (CI/CD)

## Endpoints

### Products
- `GET /api/products` — Get all products
- `GET /api/products/{id}` — Get product by ID
- `GET /api/products?slug={slug}` — Get product by URL slug
- `POST /api/products` — Create a new product
- `DELETE /api/products/{id}` — Delete a product

### Categories
- `GET /api/categories` — Get all categories
- `GET /api/categories/{id}` — Get category by ID
- `GET /api/categories?slug={slug}` — Get category by URL slug
- `POST /api/categories` — Create a new category
- `DELETE /api/categories/{id}` — Delete a category

## Getting Started

### Prerequisites
- .NET 10 SDK
- SQL Server

### Setup

1. Clone the repository
2. Update the connection string in `appsettings.Development.json`
3. Run migrations
```bash
dotnet ef database update
```
4. Run the project
```bash
dotnet run
```

## Deployment

The API is deployed to Azure App Service with a CI/CD pipeline via Azure Pipelines that automatically deploys on every push to `main`.
