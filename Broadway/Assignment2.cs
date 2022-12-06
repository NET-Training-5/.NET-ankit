using System;

 class Assignment2
 {
   public static void Main()
   {
    // Console.WriteLine("This is our second assignment");
    // ForLoop f1 = new ();
    // f1.LearnForLoop();
    // WhileLoop w1 = new ();
    // w1.LearnWhileLoop();

    // byte age =23;
    // string name  = "Ankit";
    // string m = name + "is"

    Method m=new();
    m.LearnMethod();
    m.Print("hello Ankit hows your days going on");
    m.GetMessage();

    // double dilip = Convert.ToDouble(Console.ReadLine());
    // double aankit = Convert.ToDouble(Console.ReadLine());
    
    double a = m.Add(10, 5);
    double b = m.AddS(20, 10);
    Console.WriteLine(a);
    Console.WriteLine(b);




    
   }

 }