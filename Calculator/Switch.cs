class Switch{
    public void LearnSwitch()
    {
        // This is menu

        // Console.WriteLine(" ");
        // Console.WriteLine("------Calculator which calculates only two numbers------");
        // Console.WriteLine(" ");
        
        // // Console.Write("Enter the First Nuber: ");
        // // int num1 = Convert.ToInt16(Console.ReadLine());
        // // Console.Write("Enter the Second Nuber: ");
        // // int num2 = Convert.ToInt16(Console.ReadLine());
        

        // Console.WriteLine("Enter");
        // Console.WriteLine("'1' for Addition");
        // Console.WriteLine("'2' for Subtraction");
        // Console.WriteLine("'3' for Multiplication");
        // Console.WriteLine("'4' for Division");
        // Console.WriteLine("'5' to Exit");
            // key = Console.ReadLine();

        //Calling menu from menu.cs
        Menu mm = new();
        mm.ShowMenu();

        int key = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine(" ");
        Console.Write("You Choose: " + key);
        Console.WriteLine(" ");

        //take input from user
        // Input i = new();
        // i.TakeInputFromUser();

        Console.Write("Enter the First Nuber: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the Second Nuber: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        switch (key)
        {
            case 1:
                Add a = new();
                a.Calc(num1,num2);
                break;

            case 2:
                Sub s = new();
                s.Calc(num1,num2);                
                break;

            case 3:
                Mul m = new();
                m.Calc(num1,num2);
                break;

            case 4:
                Div d = new();
                d.Calc(num1,num2);                
                break;

            case 5:
                Console.WriteLine("---------Thank You for using our service!!----------");
                break;
            
            default:
                Console.WriteLine("-----------Plz choose from the above Menu!!---------");
                break;

        }
        
                
    }
}
