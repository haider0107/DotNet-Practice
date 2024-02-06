#region sealed Methods and sealed Classes
//HousingLoanCustomer HLC = new HousingLoanCustomer(15, "Tom", "tom@gmail.com", "24525434", 7800, 23000, "34-89/A/123a");
//HLC.Details();

//class Customer //Base
//{
//    protected int _Id;
//    protected string _Name;
//    protected string _Email;
//    public Customer(int Id, string Name, string Email)
//    {
//        _Id = Id;
//        _Name = Name;
//        _Email = Email;
//    }
//    public virtual void Details()
//    {
//        Console.WriteLine(_Id);
//        Console.WriteLine(_Name);
//        Console.WriteLine(_Email);
//    }
//}
//class BankCustomer : Customer //Derived
//{
//    protected string _AcNo;
//    protected double _Bal;
//    public BankCustomer(int Id, string Name, string Email,
//        string AcNo, double Bal) : base(Id, Name, Email)
//    {
//        _AcNo = AcNo;
//        _Bal = Bal;
//    }
//    public override void Details()
//    {
//        base.Details();
//        Console.WriteLine(_AcNo);
//        Console.WriteLine(_Bal);
//    }
//}
//class LoanCustomer : BankCustomer
//{
//    protected double _LoanAmount;
//    public LoanCustomer(int Id, string Name, string Email,
//        string AcNo, double Bal, double LoanAmount) : base(Id, Name, Email, AcNo, Bal)
//    {
//        _LoanAmount = LoanAmount;
//    }
//    public override void Details()
//    {
//        base.Details();
//        Console.WriteLine(_LoanAmount);
//    }
//}
//sealed class HousingLoanCustomer : LoanCustomer //We cannot inherit HousingLoanCustomer
//{
//    string _HouseAddress;
//    public HousingLoanCustomer(int Id, string Name, string Email,
//        string AcNo, double Bal, double LoanAmount, string HouseAddress) : base(Id, Name, Email, AcNo, Bal, LoanAmount)
//    {
//        _HouseAddress = HouseAddress;
//    }

//    public override sealed void Details() // We cannot override it
//    {
//        base.Details();
//        Console.WriteLine(_HouseAddress);
//    }
//} 
#endregion

#region What is abstract Method And abstract Class
//A a; //Can create reference
////a = new A();//Cannot create object of Abstract class
//a = new B();
//a.Show();
//a.Display();


//abstract class A
//{
//    public abstract void Show();
//    public void Display()
//    {
//        Console.WriteLine("This is display from abstract class A");
//    }
//}

//class B : A
//{
//    public override void Show() // implement
//    {
//        Console.WriteLine("This show of A from B");
//    }
//    public void Test()
//    {
//        Console.WriteLine("This is test from B");
//    }
//} 
#endregion

#region Diagram - Runtime Polymorphism - Method Overriding
//Diagram D;
//#region Select a Diagram
//Console.WriteLine("1.Rectangle  2.Circle  3.Line");
//int ch = int.Parse(Console.ReadLine());
//switch (ch)
//{
//    case 1:
//        D = new Rectangle();
//        break;
//    case 2:
//        D = new Circle();
//        break;
//    case 3:
//        D = new Line();
//        break;
//    default:
//        D = new Line();
//        break;
//} 
//#endregion
//D.Draw();

//abstract class Diagram
//{
//    public abstract void Draw();
//}
//class Rectangle:Diagram
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Rectangle");
//    }
//}
//class Line : Diagram
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Line");
//    }
//}

//class Circle : Diagram
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Circle");
//    }
//} 
#endregion

#region Employee - Runtime Polymorphism - Method Overriding
//Employee E;

////E = new SoftwareEng() { Id = 12, Name = "Peter", SalaryPerDay = 23, Project = "ERP" };

//E = new Teamlead() { Id = 13, Name = "Jack", SalaryPerDay = 34, TeamSize = 15 };

//E.Details();
//Console.WriteLine(" Total salary:" + E.CalculateSalary(21));

//abstract class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double SalaryPerDay { get; set; }
//    public abstract double CalculateSalary(int NoOfDaysPresent);
//    public virtual void Details()
//    {
//        Console.WriteLine(Id);
//        Console.WriteLine(Name);
//        Console.WriteLine(SalaryPerDay);
//    }
//    public abstract int CalculateNoOfLeaves();
//}

//class SoftwareEng : Employee
//{
//    public string Project { get; set; }

//    public override void Details()
//    {
//        base.Details();
//        Console.WriteLine(Project);
//    }

//    public override double CalculateSalary(int NoOfDaysPresent)
//    {
//        double TotalSalary = SalaryPerDay * NoOfDaysPresent + (SalaryPerDay * NoOfDaysPresent * 10) / 100;
//        return TotalSalary;
//    }

//    public override int CalculateNoOfLeaves()
//    {
//        throw new NotImplementedException();
//    }
//}

//class Teamlead : Employee
//{
//    public int TeamSize { get; set; }

//    public override void Details()
//    {
//        base.Details();
//        Console.WriteLine(TeamSize);
//    }

//    //public override double CalculateSalary(int NoOfDaysPresent)
//    //{
//    //    double TotalSalary = SalaryPerDay * NoOfDaysPresent + (SalaryPerDay * NoOfDaysPresent * 12.8) / 100;
//    //    return TotalSalary;
//    //}

//    public override double CalculateSalary(int NoOfDaysPresent) => SalaryPerDay * NoOfDaysPresent + (SalaryPerDay * NoOfDaysPresent * 12.8) / 100;

//    public override int CalculateNoOfLeaves()
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion