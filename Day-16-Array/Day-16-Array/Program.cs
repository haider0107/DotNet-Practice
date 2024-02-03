#region Day 16
#region Simple Arrays
//int[] S = new int[6];
//S[0] = 67;
//S[1] = 56;
//S[2] = S[3] = 13;
//S[4] = S[0] + S[1];
//S[5] = int.Parse(Console.ReadLine());

//Console.WriteLine(S[0]);
//Console.WriteLine(S[1]);
//Console.WriteLine(S[2]);   
//Console.WriteLine(S[3]);
//Console.WriteLine(S[4]);
//Console.WriteLine(S[5]);

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine(S[i]);
//}

//for (int i = 0; i < S.Length; i++)
//{
//    Console.WriteLine(S[i]);
//}

#endregion

#region foreach and Array Class
//var S = new int[6];
//for (int i = 0; i < S.Length; i++)
//{
//    S[i] = int.Parse(Console.ReadLine());
//}

//var S = new int[] { 34, 45, 12, 78, 34, 89, 90 };

//Console.WriteLine("All The Elements are:");
//foreach (var k in S)
//{
//    Console.WriteLine(k);
//}

//Console.WriteLine("All the Odd numbers are");
//foreach (var k in S)
//{
//    if(k%2==1)
//    {
//        Console.WriteLine(k);
//    }
//}

//Console.WriteLine("Sum Of all the elements: ");
//int sum = 0;
//foreach (var k in S)
//{
//    sum = sum + k;
//}
//Console.WriteLine(sum);

//Console.WriteLine("All The Elements In Asc Order are:");
//Array.Sort(S);
//foreach (var k in S)
//{
//    Console.WriteLine(k);
//}

//Console.WriteLine("All The Elements In Desc Order are:");
//Array.Sort(S);
//Array.Reverse(S);
//foreach (var k in S)
//{
//    Console.WriteLine(k);
//}


//Console.WriteLine("Largest element from the array");
//var l = S[0];
//foreach (var k in S)
//{
//    if (k > l)
//    {
//        l = k;
//    }
//}
//Console.WriteLine(l); 
#endregion

#region 2DArrays
//int[,] A = new int[2, 3];
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        A[i, j] = int.Parse(Console.ReadLine());
//    
//}

//Console.WriteLine("2D Array is:");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(A[i, j] + "  ");
//    }
//    Console.WriteLine();
//} 
#endregion

#region Dynamic List Size Issue
//int n = 6;
//int[] A=new int[4];

//for (int i = 0; i < n; i++)
//{
//    if (i < A.Length)
//    {
//        A[i] = int.Parse(Console.ReadLine());
//    }
//    else
//    {
//        int[] B = new int[2 * A.Length];
//        for (int j = 0; j < A.Length; j++)
//        {
//            B[j] = A[j];
//        }
//    }
//} 
#endregion


#region Structures And Array Of Structures
//Student S;
//S.Sid = 78;
//S.Name = "Peter";
//S.M1 = 67;
//S.M2 = 89;

//Student St;
//St.Sid = 89;
//St.Name = "Jack";
//St.M1 = 90;
//St.M2 = 78;

//S.Display();
//S.Result();
//St.Display();
//St.Result();


//Student[] stds = new Student[10];
//stds[0].Sid = 12;
//stds[0].Name = "Peter";
//stds[0].M1 = 89;
//stds[0].M2 = 56;

//Student[] students = { new Student() { Sid = 12, Name = "Peter", M1 = 45, M2 = 56 },
//                       new Student() { Sid = 13, Name = "Jack", M1 = 34, M2 = 23 },
//                       new Student() { Sid = 14, Name = "Lilly", M1 = 15, M2 = 26 },
//                       new Student() { Sid = 15, Name = "Mark", M1 = 97, M2 = 96 },
//                       new Student() { Sid = 16, Name = "Bob", M1 = 56, M2 = 86 }
//};

//Console.WriteLine("All Students Are:");
//foreach (var student in students)
//{
//    student.Display();
//    student.Result();
//}

//struct Student
//{
//    public int Sid;
//    public string Name;
//    public double M1, M2;

//    public void Display()
//    {
//        Console.WriteLine($"Sid:{Sid} Name:{Name} M1:{M1} M2:{M2}");
//    }
//    public void Result()
//    {
//        var Avg = (M1 + M2) / 2;
//        var Result = (Avg < 35) ? "Fail" : "Pass";
//        Console.WriteLine($"Avg:{Avg} Result:{Result}");
//    }

//} 
#endregion
#endregion