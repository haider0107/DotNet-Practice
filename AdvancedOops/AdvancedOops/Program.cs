//using System.Security.Cryptography;
//using System.Xml.Linq;

//class Employee
//{
//    protected int _id;
//    protected string _name;
//    protected string _email;

//    public Employee()
//    {

//    }

//    public Employee(int id, string name, string email)
//    {
//        _id = id;
//        _name = name;
//        _email = email;
//    }
//}

//class BankCustomer:Employee
//{
//    string _AcNo;
//    double _Bal;

//    public BankCustomer(int id, string name, string email, string AcNo, double Bal):base(id,name,email)
//    {
//        //_id = id;
//        //_name = name;
//        //_email = email;
//        _AcNo = AcNo;
//        _Bal = Bal;

//    }
//}

#region Multilevel In Depth
Customer C = new Customer(12, "Peter", "peter2gmail.com");
C.Details();

BankCustomer BC = new BankCustomer(13, "Jack", "jack@gmail.com", "1234567", 70000);
BC.Details();

LoanCustomer LC = new LoanCustomer(14, "Lilly", "lilly@gmail.com", "1234556", 7800, 45000);
LC.Details();

HousingLoanCustomer HLC = new HousingLoanCustomer(15, "Tom", "tom@gmail.com", "24525434", 7800, 23000, "34-89/A/123a");
HLC.Details();

class Customer //Base
{
    protected int _Id;
    protected string _Name;
    protected string _Email;
    public Customer(int Id, string Name, string Email)
    {
        _Id = Id;
        _Name = Name;
        _Email = Email;
    }
    public virtual void Details()
    {
        Console.WriteLine(_Id);
        Console.WriteLine(_Name);
        Console.WriteLine(_Email);
    }
}
class BankCustomer : Customer //Derived
{
    protected string _AcNo;
    protected double _Bal;
    public BankCustomer(int Id, string Name, string Email,
        string AcNo, double Bal) : base(Id, Name, Email)
    {
        _AcNo = AcNo;
        _Bal = Bal;
    }
    public override void Details()
    {
        base.Details();
        Console.WriteLine(_AcNo);
        Console.WriteLine(_Bal);
    }
}
class LoanCustomer : BankCustomer
{
    protected double _LoanAmount;
    public LoanCustomer(int Id, string Name, string Email,
        string AcNo, double Bal, double LoanAmount) : base(Id, Name, Email, AcNo, Bal)
    {
        _LoanAmount = LoanAmount;
    }
    public override void Details()
    {
        base.Details();
        Console.WriteLine(_LoanAmount);
    }
}
class HousingLoanCustomer : LoanCustomer
{
    string _HouseAddress;
    public HousingLoanCustomer(int Id, string Name, string Email,
        string AcNo, double Bal, double LoanAmount, string HouseAddress) : base(Id, Name, Email, AcNo, Bal, LoanAmount)
    {
        _HouseAddress = HouseAddress;
    }

    public override void Details()
    {
        base.Details();
        Console.WriteLine(_HouseAddress);
    }
}
#endregion