using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

//Country, State and City - 1 to m

//Customer and Product - m to m

Employee E = new Employee()
{
Eid = 12,
Name = "Peter",
Salary = 7000,
AddressNvg = new Address() { Aid = 1002, DNo = "23-56", City = "Hyd" }
};
Console.WriteLine($"Eid:{E.Eid}");
Console.WriteLine($"EName:{E.Name}");
Console.WriteLine($"Salary:{E.Salary}");
Console.WriteLine($"DNo:{E.AddressNvg.DNo}");
Console.WriteLine($"City:{E.AddressNvg.City}");

[Table("Address")]
public class Address
{
    [Key]
    public int Aid { get; set; }
    public string? DNo { get; set; }
    public string? City { get; set; }
}

[Table("Department")]
public class Department
{
    [Key]
    public int Did { get; set; }
    public string? DName { get; set; }
    public string? Description { get; set; }
    public List<Employee> Employees { get; set; } //1 to Many relationship
}

[Table("Employee")]
public class Employee
{
    [Key]
    public int Eid { get; set; }
    public string? Name { get; set; }
    public double Salary { get; set; }

    public Address? AddressNvg { get; set; } //Navigation Property - 1 to 1 RelationShip

    [ForeignKey("AddressNvg")]
    public int Aid { get; set; }

    public Department DepartmentNvg { get; set; }//Navigation Property - 1 to Many relationship

    [ForeignKey("DepartmentNvg")]
    public int Did { get; set; }
}

//Many-to-Many Relationship

[Table("Student")]
public class Student
{
    [Key]
    public int Sid { get; set; }
    public string? Name { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
}

[Table("Course")]
public class Course
{
    [Key]
    public int Cid { get; set; }
    public string? CName { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
}

[Table("StudentCourse")]
public class StudentCourse
{
    [Key]
    public int SCId { get; set; }

    public Student StudentNvg { get; set; }

    [ForeignKey("StudentNvg")]
    public int Sid { get; set; }

    public Course CourseNvg { get; set; }

    [ForeignKey("CourseNvg")]
    public int Cid { get; set; }
}

public class OrgDBContext:DbContext
{

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ClassDesign;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}