#region Interfaces - Multple inheritance
//IOperations db = new DepartmentDb();
//db.Insert();
//db.Update();
//db.Delete();
//db.Select();

//IEmployeeDb edb = new EmployeeDb();
//edb.GetEmployeeByEmail();


//ICustomerDb customerDb = new Customerdb();
//customerDb.GetCustomersByCityId();

//interface IOperations
//{
//    void Insert();
//    void Update();
//    void Delete();
//    void Select();
//}

//interface IEmployeeDb
//{
//    void GetEmployeeByEmail();
//}

//interface IDepartmentDb
//{
//    void GetDepartmentByDName();
//}

//class EmployeeDb : IOperations, IEmployeeDb
//{
//    public void Delete()
//    {
//        Console.WriteLine("Delete");
//    }

//    public void GetEmployeeByEmail()
//    {
//        Console.WriteLine("Get Employee By Email");
//    }

//    public void Insert()
//    {
//        Console.WriteLine("Insert");
//    }

//    public void Select()
//    {
//        Console.WriteLine("Select");
//    }

//    public void Update()
//    {
//        Console.WriteLine("Update");
//    }
//}


//class DepartmentDb : IOperations, IDepartmentDb
//{
//    public void Delete()
//    {
//        throw new NotImplementedException();
//    }

//    public void GetDepartmentByDName()
//    {
//        throw new NotImplementedException();
//    }

//    public void Insert()
//    {
//        throw new NotImplementedException();
//    }

//    public void Select()
//    {
//        throw new NotImplementedException();
//    }

//    public void Update()
//    {
//        throw new NotImplementedException();
//    }
//}

//interface ICustomerDb : IOperations
//{
//    void GetCustomerByEmai();
//    void GetCustomerByOrderId();
//    void GetCustomersByCityId();
//}

//class Customerdb : ICustomerDb
//{
//    public void Delete()
//    {
//        throw new NotImplementedException();
//    }

//    public void GetCustomerByEmai()
//    {
//        throw new NotImplementedException();
//    }

//    public void GetCustomerByOrderId()
//    {
//        throw new NotImplementedException();
//    }

//    public void GetCustomersByCityId()
//    {
//        throw new NotImplementedException();
//    }

//    public void Insert()
//    {
//        throw new NotImplementedException();
//    }

//    public void Select()
//    {
//        throw new NotImplementedException();
//    }

//    public void Update()
//    {
//        throw new NotImplementedException();
//    }
//} 
#endregion
#region Partial Classes
//Employee E = new Employee();
//E.SomeImportantImplementation();
//E.Test();

//public partial class Employee
//{
//    public void Show()
//    {
//        Console.WriteLine("This is show");
//    }

//    public partial void Test()
//    {
//        Console.WriteLine("This is test");
//    }
//}

//public partial class Employee
//{
//    #region Don't touch it
//    public void SomeImportantImplementation()
//    {
//        Console.WriteLine("Some Important Implementation");
//    }
//    #endregion

//    public partial void Test();

//    public void insert()
//    {
//        Console.WriteLine("Insert");
//    }
//} 
#endregion
#region Value Type Vs Ref Type
//Console.WriteLine("value types");
//int i;
//i = 10;

//Console.WriteLine("Ref Type");
//int[] array = new int[2];
//array[0] = 13;
//array[1] = 34;

//Console.WriteLine("Good");



//Employee E1 = new Employee() { id = 89 };
//Console.WriteLine("E1 Id:" + E1.id);
//Employee E2;
//E2 = E1;
//Console.WriteLine("E2 Id:"+E2.id);

////Student[] S = { new Student() { Sid = 10 }, new Student() { Sid = 12 } };

//E2.id = 100;
//Console.WriteLine("E1 Id:" + E1.id);
//Console.WriteLine("E2 Id:" + E2.id);

//Student S1;
//S1.Sid = 89;

//Student S2;
//S2 = S1;
//Console.WriteLine($"S1 Sid:{S1.Sid}  S2 Sid:{S2.Sid}");

//S2.Sid = 100;
//Console.WriteLine($"S1 Sid:{S1.Sid}  S2 Sid:{S2.Sid}");
//class Employee
//{
//    public int id { get; set; }
//}

//struct Student
//{
//    public int Sid;
//} 
#endregion
#region Call by reference
//Employee E1 = new Employee() { id = 99 };
//Test t = new Test();

//Console.WriteLine("Id before call " + E1.id);
//t.Change(E1);
//Console.WriteLine("Id after call " + E1.id);


//class Test
//{
//    public void Change(Employee E2)
//    {
//        E2.id = 500;
//        Console.WriteLine("Id in call " + E2.id);
//    }
//}

//class Employee
//{
//    public int id { get; set; }
//} 
#endregion
#region ref Parameters
//Test t = new Test();
//int id = 99;
//Console.WriteLine("Id before call " + id);
//t.Change(ref id);
//Console.WriteLine("Id after call " + id);


//class Test
//{
//    public void Change(ref int id)
//    {
//        id = 500;
//        Console.WriteLine("Id in call " + id);
//    }
//} 
#endregion
#region out Parameters
//Test t = new Test();
//int id;
//t.Assign(out id);
//Console.WriteLine("Id after call " + id);


//int i;

//int.TryParse(Console.ReadLine(),out i);

//class Test
//{
//    public void Assign(out int id)
//    {
//        id = 500;
//        Console.WriteLine("Id in call " + id);
//    }
//} 
#endregion