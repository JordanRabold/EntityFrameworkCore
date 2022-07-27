using EntityFrameworkCore;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new() // creating query
{
    FullName = "Jordan Rabold",
    EmailAddress = "J.Radbold@edu.net",
    DateOfBirth = new DateTime(2022, 1, 1)
};

Student s2 = new() // creating query
{
    FullName = "Jim Halpert",
    EmailAddress = "J.Halpert@edu.net",
    DateOfBirth = new DateTime(2021, 2, 1)
};

// Create
dbContext.Students.Add(s); // Prepares the student insert statement, but doesnt run it
dbContext.SaveChanges(); // executes pending insert. This will execute any pending insert, update, or delete queries

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// retrieve students from db
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
//allStudents = (from stu in dbContext.Students
//              select stu).ToList(); // Query syntax


foreach(Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}