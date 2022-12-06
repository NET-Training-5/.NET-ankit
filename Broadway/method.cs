class Method
{
    
/* Simplest possible : returns nothins, take no arguments
*/

    public void LearnMethod()
    {
        Console.WriteLine("==========Hello world----------");
    }
    // returns nothing , takes some arguments

    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    //retunrs something, takes no arguments

    public string GetMessage()
    {
        return " Kathmandu ";
    }

    //Returns something, takes some arguments
    public double Add(double a, double b)
    {
        return a+b;
    }

    //Expression bodied members
    public double AddS(double a, double b)=> a+b;
    
    //Takes arguments or not, returns multiple values

}



