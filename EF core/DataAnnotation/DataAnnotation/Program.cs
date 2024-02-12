using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello World");

var db = new OrgDBContext();
//Select All
var emps = db.Employees.ToList();
//var emps = (from res in db.Employees select res).ToList();
foreach (var e in emps)
{
    Console.WriteLine($"Eid:{e.Eid} Ename:{e.EName} ");
}

//Select Employee With id=2
//var e = db.Employees.Find(2);
//Console.WriteLine($"Eid:{e.Eid} Ename:{e.EName} Gender:{e.Gender} CreatedOn:{e.CreatedOn}");

//Select employee name=peter
//var e = db.Employees.Where(x => x.EName == "Peter").FirstOrDefault();
//Console.WriteLine($"Eid:{e.Eid} Ename:{e.EName} Gender:{e.Gender} CreatedOn:{e.CreatedOn}");


//Update emp 2 Did to 1000
//var e = db.Employees.Find(2);
//e.Did = 1000;
//db.Employees.Update(e);
//db.SaveChanges();

//Delete emp 2
//var e = db.Employees.Find(2);
//db.Employees.Remove(e);
//db.SaveChanges();

//var e = new Employee()
//{
//    Eid = 3,
//    EName = "Lilly",
//    Gender = "F",
//    Email = "lilly@gmail.com",
//    ConfirmEmail = "lilly@gmail.com",
//    Salary = 70000,
//    DOJ = new DateTime(2010, 3, 10),
//    DOB=new DateTime(1984,11,6),
//    Did=1000,
//    LkInProfileLink="https://wwww.Manzoorthetrainer.com"
//};

//db.Employees.Add(e);
//db.SaveChanges();

[Table("Employee")]
public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Eid { get; set; }

    [Required]
    [Column("EmployeeName")]
    public string? EName { get; set; }

    [MaxLength(2)]
    public string? Gender { get; set; }

    [Column(TypeName = "varchar(50)")]
    [EmailAddress]
    public string? Email { get; set; }

    [NotMapped]  // will not store in database
    [Compare("Email")]
    public string? ConfirmEmail { get; set; }

    [Range(0, 100000)]
    public double Salary { get; set; }

    [Column(TypeName = "Date")]
    public DateTime DOJ { get; set; }

    public DateTime DOB { get; set; }

    [Url]
    public string? LkInProfileLink { get; set; }
    public int? Did { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}

public class OrgDBContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("postgres://tlocyvts:xvJZsRIYNIqkg-TtVxxjqUM8rPw6aB68@berry.db.elephantsql.com/tlocyvts");
    }

    public DbSet<Employee> Employees { get; set; }
}
