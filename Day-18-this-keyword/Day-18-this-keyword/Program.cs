// this keyword

Customer C = new Customer(Name: "Rohan", Id: 22, Bal: 58455, Spouse: "Rani");
C.Details();
class Customer
{
    int Id;
    string Name;
    double Bal;
    string Spouse;

    public Customer(int Id, string Name, double Bal) {
        this.Id = Id;
        this.Name = Name;
        this.Bal = Bal;
    }

    public Customer(int Id, string Name, double Bal,string Spouse):this(Id,Name,Bal) {
        this.Spouse = Spouse;
    }

    public void Details()
    {
        Console.WriteLine($"Id:{Id} Name:{Name}  Bal:{Bal} Spouse:{Spouse}");
    }

}

#region Design - 3 (this Keyword)
//Customer C1 = new Customer(13, "Jack", 1300);

//Customer C = new Customer(12, "Peter", 1200, "Lilly");
//C.Details();

//class Customer //43
//{
//    int Id;
//    string Name;
//    double Bal;
//    string Spouse;
//    public Customer()
//    {
//        Console.WriteLine("Default Constructor");
//    }
//    public Customer(int Id, string Name, double Bal):this()
//    {
//        this.Id = Id;
//        this.Name = Name;
//        this.Bal = Bal;
//    }
//    public Customer(int Id, string Name, double Bal, string Spouse):this(Id,Name,Bal)
//    {
//        //this.Id = Id;
//        //this.Name = Name;
//        //this.Bal = Bal;
//        this.Spouse = Spouse;
//    }
//    public void Details()
//    {
//        Console.WriteLine($"Id:{Id} Name:{Name}  Bal:{Bal} Spouse:{Spouse}");
//    }
//    public void Deposite(double amt)
//    {
//        Bal = Bal + amt;
//    }
//    public void Deposite(double amt, bool showDetails)
//    {
//        Bal = Bal + amt;
//        if (showDetails == true)
//        {
//            Console.WriteLine($"Id:{Id} Name:{Name}  Bal:{Bal} Spouse:{Spouse}");
//        }
//    }
//    public void Withdraw(double amt)
//    {
//        Bal = Bal - amt;
//    }
//} 
#endregion
#region Design - 4 (Optional Parameters)
//Customer C = new Customer();

//Customer C = new Customer(12, "Peter", 1200);

//Customer C1 = new Customer();

//Customer C = new Customer(Id:12, Name:"Peter", Bal:1200, Spouse:"Lilly");

//Customer C = new Customer(Id: 12, Name: "Peter", Bal: 1200, Contact: "987876564");

//Customer C = new Customer(Bal: 1200, Spouse: "Lilly", Id: 12, Name: "Peter",Contact:"9878765453");
//C.Details();
//C.Deposite(4500);
//C.Deposite(amt:3400, showDetails:true);

//class Customer //31 Lines
//{
//    int _Id;
//    string _Name;
//    double _Bal;
//    string _Spouse;
//    string _Contact;
//    public Customer(int Id, string Name = null, double Bal = 0, string Spouse = null, string Contact = null)
//    {
//        _Id = Id;
//        _Name = Name;
//        _Bal = Bal;
//        _Spouse = Spouse;
//        _Contact = Contact;
//    }
//    public void Details()
//    {
//        Console.WriteLine($"Id:{_Id} Name:{_Name}  Bal:{_Bal} Spouse:{_Spouse} Contact:{_Contact}");
//    }
//    public void Deposite(double amt, bool showDetails = false)
//    {
//        _Bal = _Bal + amt;
//        if (showDetails == true)
//        {
//            Console.WriteLine($"Id:{_Id} Name:{_Name}  Bal:{_Bal} Spouse:{_Spouse}");
//        }
//    }
//    public void Withdraw(double amt)
//    {
//        _Bal = _Bal - amt;
//    }
//} 
#endregion
#region Design - 5 (Why Do We Need Properties)
//LoanCustomer LC1=new LoanCustomer();
//LC1._Id = -12;
//LC1._Name = "Peter";
//LC1._Spouse = "Lilly";
//Console.WriteLine($"Id:{LC1._Id} Name:{LC1._Name} Spouse:{LC1._Spouse}");

//UI
//LoanCustomer LC2 = new LoanCustomer(-12,"Peter");
//Console.WriteLine(LC2.GetId());
//Console.WriteLine(LC2.GetName());
//LC2.SetSpouse("Lilly");
//Console.WriteLine(LC2.GetSpouse());

//LC2._Id = 13;
//LC2._Name = "Lilly";
//Console.WriteLine($"Id:{LC2._Id} Name:{LC2._Name}");

//BLL
//class LoanCustomer
//{
//    int _Id;
//    string _Name;
//    string _Spouse;
//    public LoanCustomer(int Id = 0, string Name = null, string Spouse=null)
//    {
//        if (Id > 0)
//        {
//            _Id = Id;
//        }
//        _Name = Name;
//    }
//    //public void Details()
//    //{
//    //    Console.WriteLine($"Id:{_Id} Name:{_Name}");
//    //}

//    public int GetId()
//    {
//        return _Id;
//    }

//    public string GetName()
//    {
//        return _Name;
//    }

//    public void SetSpouse(string Spouse)
//    {
//        _Spouse = Spouse;
//    }
//    public string GetSpouse()
//    {
//        return _Spouse;
//    }
//} 
#endregion
#region Design - 6 (Properties)
//LoanCustomer LC1 = new LoanCustomer(12, "Peter");
//Console.WriteLine(LC1.Id);
//Console.WriteLine(LC1.Name);
//LC1.Spouse = "Lilly";
//Console.WriteLine(LC1.Spouse);

//class LoanCustomer
//{
//    int _Id;
//    public int Id { get { return _Id; } }

//    string _Name;
//    public string Name { get { return _Name;} }

//    string _Spouse;

//    public string Spouse
//    {        
//        get
//        {
//            return _Spouse;
//        }
//        set
//        {
//            if (value.Length >= 6)
//                _Spouse = value;
//        }
//    }

//    public LoanCustomer(int Id = 0, string Name = null, string Spouse = null)
//    {
//        if (Id > 0)
//        {
//            _Id = Id;
//        }
//        _Name = Name;
//    }

//} 
#endregion
#region Design - 7 (Auto Properties)
//var LC = new LoanCustomer() { Id = 12, Name = "Jack", Spouse = "Lilly" };

//var LC = new LoanCustomer(12) { Name = "Jack" };
//LC.Spouse = "Lilly";

//Console.WriteLine($"Id:{LC.Id} Name:{LC.Name} Spouse:{LC.Spouse}");

//class LoanCustomer
//{
//    public int Id { get; }
//    public string Name { get; set; }
//    public string? Spouse { get; set; }
//    public LoanCustomer(int _Id)
//    {
//        Id = _Id;
//    }
//} 
#endregion