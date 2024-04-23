# 🧑🏻‍💻 EmpireManager

EmpireManager is a comprehensive web application designed to streamline business operations by effectively managing various aspects of the organization. It provides a centralized platform for handling employees, clients, products, orders, and sales items, catering to the diverse needs of a business environment.

## Features

- **Employees:** Add, delete, modify, search by ID and name, list all employees.
- **Clients:** Add, delete, modify, search by ID and name, list all clients.
- **Products:** Add, delete, modify, search by ID and name, list all products.
- **Orders:** Register sales, list sales.
- **Sales Items:** Insert, delete sales items.

## Technologies Used

- **.NET Core 8.0:**
- **Entity Framework Core:** 
- **SQL Server:** 

## Project Structure

The project is organized as follows:

- **EmpireManager.Domain:** Contains domain classes such as Funcionario, Cliente, Produto, Pedido, and ItemVenda.
- **EmpireManager.Data:** Contains the database context (ApplicationDbContext) and migration configurations.
- **Controllers:** Contains controllers for each entity, responsible for handling HTTP requests and interacting with the database.

## How to Run

1. Clone the repository to your local machine.
2. Ensure you have the .NET SDK installed.
3. Open the project in your preferred code editor.
4. Configure the database connection string in the `appsettings.json` file.
5. Run the `dotnet run` command in the terminal to start the application.

