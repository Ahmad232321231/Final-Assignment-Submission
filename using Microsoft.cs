using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

// Student entity (represents the Students table)
public class Student
{
    public int Id { get; set; }   // Primary Key
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
}

// Database context (manages connection and tables)
public class SchoolContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Creates a local SQLite database file called students.db
        optionsBuilder.UseSqlite("Data Source=students.db");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Final Assignment: Code-First EF Example");
        Console.WriteLine("Creating database and adding a student...\n");

        using var db = new SchoolContext();

        // Create database if it does not exist
        db.Database.EnsureCreated();

        // Add a sample student if none exist
        if (!db.Students.Any())
        {
            db.Students.Add(new Student
            {
                FirstName = "Ada",
                LastName = "Lovelace",
                Email = "ada@example.com"
            });
            db.SaveChanges();
        }

        // Display all students
        Console.WriteLine("Current Students in Database:");
        foreach (var s in db.Students)
        {
            Console.WriteLine($"[{s.Id}] {s.FirstName} {s.LastName} - {s.Email}");
        }
    }
}
