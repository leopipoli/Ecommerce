# Marketplace_Api
This is a RESTful API built with ASP.NET Core for managing tasks. The API provides endpoints for creating, reading, updating, and deleting tasks. It supports CRUD operations and uses a simple in-memory database for storage.

## Features
Get All Tasks: Retrieve a list of all tasks.
Get Task by ID: Retrieve a specific task by its ID.
Create Task: Create a new task.
Update Task: Update an existing task.
Delete Task: Delete a task by its ID.
Prerequisites
.NET 8.0
Visual Studio 2022 or VS Code

## Error Handling
404 Not Found: Returned when a task is not found.
400 Bad Request: Returned for invalid request data.
500 Internal Server Error: Returned for unexpected server errors.
Authentication
This API does not include authentication. You can add authentication by configuring JWT or other mechanisms as needed.

## Testing
You can use tools like Postman or cURL to test the API endpoints.

## Contributing
Fork the repository.
Create a new branch (git checkout -b feature-branch).
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature-branch).
Create a new Pull Request.
License
This project is licensed under the MIT License - see the LICENSE file for details.
