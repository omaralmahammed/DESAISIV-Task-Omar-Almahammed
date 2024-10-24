# DESAISIV-Task-Omar-Almahammed


Overview
This project is a simple RESTful API for managing a book library, developed as part of the selection process for an internship at DESAISIV. The API allows users to perform CRUD operations on a collection of books. The project implements basic validation, error handling, and API documentation using Swagger.

Objective
Create a RESTful API using ASP.NET Core to manage a collection of books in a library. The API should support the following operations:

Add a new book
Retrieve a list of all books
Retrieve details of a specific book by its ID
Update an existing book by its ID
Delete a book by its ID
Features
API Endpoints
The following API endpoints are available:

GET /api/books
Retrieves a list of all books.

GET /api/books/{id}
Retrieves the details of a specific book by its ID.

POST /api/books
Adds a new book to the library.

PUT /api/books/{id}
Updates an existing book's details by its ID.


Database
The API uses Entity Framework Core with a SQLite database. Migrations are implemented to handle the creation of the database schema.

Validation
The following validation rules are applied:

Title and Author are required fields and cannot be empty.
Publication Year must be a valid integer year.
Error Handling
Appropriate HTTP status codes are returned for different outcomes:

200 OK for successful GET requests.
201 Created for successful POST requests.
400 Bad Request for validation errors.
404 Not Found for requests to non-existent resources.
Documentation
The API is documented using Swagger (Swashbuckle), which provides an interactive interface for exploring the available endpoints.
