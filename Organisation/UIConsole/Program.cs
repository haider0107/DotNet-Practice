using BLL;

Employee employee = new Employee() { Id = 1, Name = "Anurag", SalPerDay = 23.5 };

Console.WriteLine("Enter number of working days...");
int n = int.Parse(Console.ReadLine());

var Salary = employee.CalculateSalary(n);

Console.WriteLine($"Eid: {employee.Id} Employee Name: {employee.Name} Salary Per Day: {employee.SalPerDay} Total Salary: {Salary}");

Console.ReadLine();