#region Design - 1 (Class, Feilds, Methods, Objects)
//Customer C = new Customer();  //Creating Reference and Object

//Customer C;         //Creating Reference
//C = new Customer(); //Creating Object


//var C = new Customer();
//C.CreateCustomer(12, "Peter", 8000);//Initializing explicitly
//C.Details();

//C.CreateCustomer(13, "Lilly", 9000);// Reinitializing Object

//class Customer
//{
//    int Id;
//    string Name;
//    double Bal;
//    public void CreateCustomer(int i, string n, double b)
//    {
//        Id = i;
//        Name = n;
//        Bal = b;
//    }
//    public void Details()
//    {
//        Console.WriteLine($"Id:{Id} Name:{Name}  Bal:{Bal}");
//    }
//    public void Deposite(double amt)
//    {
//        Bal = Bal + amt;
//    }
//    public void Withdraw(double amt)
//    {
//        Bal = Bal - amt;
//    }
//} 
#endregion
#region Design - 2 (Constructors & Method - Overloading)
//var C = new Customer(12, "Jack", 7000, "Lilly");
//C.Deposite(2000);
//C.Deposite(5000, true);
//class Customer
//{
//    int Id;
//    string Name;
//    double Bal;
//    string Spouse;
//    public Customer()
//    {
//        Console.WriteLine("Default Constructor");
//    }
//    public Customer(int i, string n, double b)
//    {
//        Id = i;
//        Name = n;
//        Bal = b;
//    }
//    public Customer(int i, string n, double b, string s)
//    {
//        Id = i;
//        Name = n;
//        Bal = b;
//        Spouse = s;
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



#region Topper Student From Array Of Structures
//Student[] S ={new Student() { Id=12,Name="Peter",M1=56,M2=78},
//    new Student() { Id=13,Name="Jack",M1=86,M2=67},
//    new Student() { Id=14,Name="Lilly",M1=76,M2=34},
//    new Student() { Id=15,Name="Mark",M1=36,M2=66},
//    new Student() { Id=16,Name="Bob",M1=26,M2=12}
//};

//Console.WriteLine("All Students");
//foreach (var item in S)
//{
//    item.Details();
//}

//Student Topper = S[0];
//foreach (var item in S)
//{
//    if (item.Avg > Topper.Avg)
//    {
//        Topper = item;
//    }
//}
//Console.WriteLine("Topper");
//Topper.Details();

//struct Student
//{
//    public int Id;
//    public string Name;
//    public int M1, M2;
//    public double Avg;

//    public void Details()
//    {
//        Avg = (M1 + M2) / 2.0;
//        Console.WriteLine($"Id:{Id} Name:{Name} Avg:{Avg}");
//    }
//} 
#endregion