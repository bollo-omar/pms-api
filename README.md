# Product Management System API - Readme

Welcome to the Product Management System (PMS) API repository - a backend solution for the efficient management of products within the Product Management System.

## Table of Contents

- [Introduction](#introduction)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Endpoints](#endpoints)
- [Database](#database)
- [Contributing](#contributing)

## Introduction

The Product Management System API is the backend component of the PMS application. It provides the necessary endpoints and functionalities to support the product management workflow. This API is built using .NET Web API, C#, and Entity Framework Core, offering seamless interaction between the frontend and the database.

## Technologies Used

![.NET Core Web API](https://img.shields.io/badge/.NET%20Web%20API-v7.0-blue)
![C#](https://img.shields.io/badge/C%23-v11.0-blue)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-v7.0-blue)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-blue)

- **.NET Web API:** A framework for building HTTP-based services that can be consumed by various clients.

- **C#:** The primary programming language used to develop the API.

- **Entity Framework Core:** A powerful ORM (Object-Relational Mapping) framework for interacting with the database.

- **SQL Server:** A relational database management system used to store and manage product data.

## Getting Started

To get started with the Product Management System API, follow these steps:

1. **Clone the Repository:**
   ```
   git clone https://github.com/bollo-omar/pms-api.git
   cd pms-api
   ```

2. **Install Dependencies:**
   ```
   dotnet restore
   ```

3. **Update Connection String:**
   Update the connection string in the `appsettings.json` file to point to your SQL Server database.

4. **Run the API:**
   ```
   dotnet run
   ```

5. **Access the API:**
   The API will be accessible at `http://localhost:5000` or `https://localhost:5001`.

## Endpoints

The Product Management System API provides a range of endpoints to interact with the frontend application. These include but are not limited to:

- `GET /api/products`: Retrieve a list of products.
- `GET /api/products/{id}`: Retrieve a specific product by ID.
- `POST /api/products`: Create a new product.
- `PUT /api/products/{id}`: Update an existing product.
- `DELETE /api/products/{id}`: Delete a product.

Please refer to the API documentation or source code for a comprehensive list of endpoints and their functionalities.

## Database

The API interacts with a SQL Server database to store and manage product data. The database schema and structure are managed by Entity Framework Core migrations. Make sure to configure your database connection string in the `appsettings.json` file before running the API.

## Contributing

We welcome contributions to enhance the Product Management System API. To contribute:

1. Fork the repository and create a new branch.
2. Make your changes and test thoroughly.
3. Submit a pull request describing your changes and their purpose.

---

We hope you find the Product Management System API crucial for your product management needs. If you encounter any issues or have suggestions for improvements, please don't hesitate to [contact us](mailto:contact@pms.com). Your feedback is highly appreciated!
