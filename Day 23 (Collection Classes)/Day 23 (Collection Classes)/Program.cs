#region Collection Classes
//using System.Collections;
//Stack S = new Stack();
//S.Push(23);
//S.Push(34);
//S.Push(90);
//S.Push(74);

//while (S.Count!=0)
//{
//    Console.WriteLine(S.Pop());
//}

//Queue Q = new Queue();
//Q.Enqueue("Manzoor");
//Q.Enqueue("The");
//Q.Enqueue("Trainer");
//while (Q.Count!=0)
//{
//    Console.WriteLine(Q.Dequeue());
//}

//Stack S = new Stack();
//S.Push(23);
//S.Push(34);
//S.Push("MTT");
//S.Push(74);

//int sum = 0;

//while (S.Count != 0)
//{
//    sum = sum + int.Parse(S.Pop().ToString());
//}
//Console.WriteLine(sum); 
#endregion
#region Generic Collection and List Of Int
//using System.Collections.Generic;
//using System.Linq;
//Stack<int> S = new Stack<int>();
//S.Push(23);
//S.Push(34);
//S.Push(34);
//S.Push(74);

//int sum = 0;

//while (S.Count != 0)
//{
//    sum = sum + S.Pop();
//}
//Console.WriteLine(sum);

//List<int> ls = new List<int>();
//ls.Add(56);
//ls.Add(45);
//ls.Add(34);
//ls.Add(50);
//ls.Add(56);
//ls.Add(58);
//foreach (var item in ls)
//{
//    Console.WriteLine(item);
//}

//ls.Remove(34);
//foreach (var item in ls)
//{
//    Console.WriteLine(item);
//} 
#endregion
#region List Of Objects and LINQ
//List<Employee> employees = new List<Employee>();
//employees.Add(new Employee() { Id = 12, Name = "Peter", SalPerDay = 78.9 });
//employees.Add(new Employee() { Id = 13, Name = "Jack", SalPerDay = 68.9 });
//employees.Add(new Employee() { Id = 14, Name = "Lilly", SalPerDay = 43.9 });
//employees.Add(new Employee() { Id = 15, Name = "Mark", SalPerDay = 77.7 });

//Console.WriteLine("All Employees");
//foreach (var E in employees)
//{
//Console.WriteLine($"Id:{E.Id} Name:{E.Name} " +
//    $"SalPerDay:{E.SalPerDay} TotalSalary:{E.CalculateSalary(24)}");
//}

//Console.WriteLine("All Employees sorted by Name");
//foreach (var E in employees.OrderByDescending(x => x.Name))
//{
//Console.WriteLine($"Id:{E.Id} Name:{E.Name} " +
//    $"SalPerDay:{E.SalPerDay} TotalSalary:{E.CalculateSalary(24)}");
//}

//Console.WriteLine("All Employees With SalPerday>50");
//foreach (var E in employees.Where(x => x.SalPerDay >= 50))
//{
//Console.WriteLine($"Id:{E.Id} Name:{E.Name} " +
//    $"SalPerDay:{E.SalPerDay} TotalSalary:{E.CalculateSalary(24)}");
//}

//Console.WriteLine("Employee With highest Salary");
//Employee E1 = employees.OrderByDescending(x => x.SalPerDay).Take(1).ToList()[0];
//Console.WriteLine($"Id:{E1.Id} Name:{E1.Name} " +
//        $"SalPerDay:{E1.SalPerDay} TotalSalary:{E1.CalculateSalary(24)}");


//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public double SalPerDay { get; set; }
//    public double CalculateSalary(int n) => SalPerDay * n;
//} 
#endregion
#region Exception Handling

//try
//{
//    int i = int.Parse(Console.ReadLine());
//    int[] a = { 12, 45, 78 };
//    Console.WriteLine(a[2]);
//    int x = 10 / i;
//}
//catch (DivideByZeroException D)
//{
//    Console.WriteLine("No you canoot divide By Zero");
//}
//catch (IndexOutOfRangeException I)
//{
//    Console.WriteLine("No that index is not available");
//}
//catch (Exception E)
//{
//    Console.WriteLine(E.Message);
//}
//finally
//{
//    Console.WriteLine("Close the connection");
//} 
#endregion