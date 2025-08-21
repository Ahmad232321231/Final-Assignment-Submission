# Final Assignment – Entity Framework Code-First

This project is a simple **console application** that demonstrates **Entity Framework Core Code-First** by creating a `Student` database and inserting a sample record.

## Features
- Uses **Entity Framework Core (Code-First)**
- Creates a local **SQLite database** (`students.db`)
- Defines a `Student` entity with `Id`, `FirstName`, `LastName`, and `Email`
- Automatically creates the database if it does not exist
- Inserts **Ada Lovelace** as the first student (if none exist)
- Prints all students to the console

## Requirements
- .NET 8 SDK
- EF Core packages:
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Sqlite

## How to Run
1. Install dependencies:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore --version 8.*
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.*
Run the project:

dotnet run

Final Assignment: Code-First EF Example
Creating database and adding a student...

Current Students in Database:
[1] Ada Lovelace - ada@example.com
