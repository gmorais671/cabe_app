# Stock Control API - .NET Core
This project is a personal study initiative to refactor and modernize an old inventory management application I originally built in 2021. The main goal is to apply modern software development practices and patterns using the latest features of the ASP.NET Core framework.

The original application was functional, but this reimplementation focuses on creating a cleaner, more maintainable, and scalable solution by leveraging technologies like Entity Framework Core, dependency injection, and best practices for API design.

## Technologies Used
- Framework: ASP.NET Core 8
- ORM: Entity Framework Core 8
- Database: Designed to be compatible with SQL Server, PostgreSQL, or SQLite.
- Architecture: RESTful API with a focus on clean architecture principles.

## Implemented Features
As of now, the core CRUD (Create, Read, Update, Delete) operations for the main entities have been implemented.

### 1. Products Management (/api/products)
Full support for managing the product catalog.
- GET /api/products: Retrieves a list of all products.
- GET /api/products/{id}: Retrieves a specific product by its ID.
- POST /api/products: Creates a new product.
- PUT /api/products/{id}: Updates an existing product.
- DELETE /api/products/{id}: Deletes a product.

### 2. Contacts Management (/api/contacts)
Full support for managing contacts, which can be either clients or suppliers.
- GET /api/contacts: Retrieves a list of all contacts.
- GET /api/contacts/{id}: Retrieves a specific contact by its ID.
- POST /api/contacts: Creates a new contact.
- PUT /api/contacts/{id}: Updates an existing contact.
- DELETE /api/contacts/{id}: Deletes a contact.

## Next Steps (Roadmap)
The current implementation provides the foundation for the system. The next major features to be developed are the core business logic modules:

[ ] Implement Purchase Module:
- Create a POST /api/purchases endpoint.
- The endpoint will receive a supplier ID and a list of products.
- It must run within a database transaction to ensure atomicity.
- Successfully completing a purchase will update the stock quantity of the corresponding products.

[ ] Implement Sale Module:
- Create a POST /api/sales endpoint.
- The endpoint will receive a client ID and a list of products.
- It must first validate if there is enough stock for every product in the order.
- If stock is sufficient, it will run a transaction to register the sale and decrease the stock quantities.

[ ] Add Authentication & Authorization:
- Implement JWT-based authentication to secure the API endpoints.

[ ] Develop a Dashboard Endpoint:
- Create an endpoint to provide key business metrics (e.g., total sales, top-selling products).
