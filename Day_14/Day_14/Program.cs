#region Basic Operations
//int a, b, c;
//a = 20;
//b = 30;
//c = a + b;
//Console.WriteLine("Sum of a and b is c");
//Console.WriteLine("Sum of " + a + " and " + b + " is " + c);
//Console.WriteLine("Sum of {0} and {1} is {2}",a,b,c);
//Console.WriteLine($"Sum of {a} and {b} is {c}"); 
#endregion

#region Parsing
//double a, b, c;
//Console.WriteLine("Enter the value of A");
//a = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the value of B");
//b = double.Parse(Console.ReadLine());
//c = a + b;
//Console.WriteLine($"Sum of {a} and {b} is {c}"); 
#endregion

#region TypeCasting
//Console.WriteLine(5 / 2);
//Console.WriteLine(5 % 2);
//Console.WriteLine(5.0 / 2);
//Console.WriteLine(5.0 / 2.0);
#endregion

#region Insert Operation
//int a = 5, b = 2;
//int c = a + b;
//Console.WriteLine("Enter the value of A");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the value of B");
//b = int.Parse(Console.ReadLine());
//Console.WriteLine((double)a / b);
//Console.WriteLine(a / (double)b);
//Console.WriteLine((double)(a / b));
//Console.WriteLine(a + b);
#endregion

#region Datatypes And DateTime
//int? did = null; // ? allow null value because int can't have null value

//string S = "Manzoor The Trainer";
//Console.WriteLine(S);

//int a = 20;
//int b = 70;
//string s = a.ToString(); // convert to string

//DateTime dt = DateTime.Now; // current time
//Console.WriteLine(dt.ToString());
//Console.WriteLine(dt.ToShortDateString());
//Console.WriteLine(dt.ToShortTimeString());
//Console.WriteLine(dt.ToString("MM/dd/yyyy"));
//Console.WriteLine(dt.AddDays(10).ToShortDateString()); // date after 10 days


//Console.WriteLine(int.MaxValue);
//Console.WriteLine(int.MinValue);


//bool flag = a > b;
//Console.WriteLine(flag);
//flag = !flag;
//Console.WriteLine(flag);

//CTS - Common Type System

// int a; C#
// Dim a as Integer // vb.net code variable initialization

//Int32 x;
//x = 90;

#endregion

#region var Vs dynamic
//int a = 10;
//double b = 30.5;
//String S = "MTT";

//var a = 10;
//var b = 30.5;
//var S = "MTT";
//var flag = false;

//var y = 90;//call the method;
//y = 90;
////y = "MTT";

//dynamic x;
//x = 90;
//Console.WriteLine(x);

//x = "MTT";
//Console.WriteLine(x);

//x = 90.8;
//Console.WriteLine(x);

//Operation.Add(34, 45);
//Operation.Add(3.4, 4.5);
//Operation.Add(3, 4.5);
//Operation.Add(3.5, 4);
//Operation.Add("MTT", " Bootcamp");
//Operation.Add(67, " Bootcamp"); 
#endregion

//ref and out parameter


#region int.Parse() vs int.TryParse()
//int a=89;
//Console.WriteLine("Enter the value of a");
//a=int.Parse(Console.ReadLine());
//Console.WriteLine(a);

//int  a;
//int.TryParse(Console.ReadLine(),out a); // work like a try/catch where it help from breaking the code if value is not passed 
//Console.WriteLine(a); 
#endregion


static class Operation
{
    public static void Add(dynamic a, dynamic b)
    {
        Console.WriteLine(a + b);
    }
}