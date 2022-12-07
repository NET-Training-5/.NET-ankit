class Method
{
    
/* Simplest possible : returns nothings, take no arguments
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
    //Find sum and product of supplied number
    //Tuples concept using

    public(double, double) GetSumAndProduct(float a, float b)
    {
            var sum = a+b;
            var product = a*b;

            return(sum, product);
    }

    //cw Write  a method which takes 3 numbers and returns average of all.

    public double AvgNumber(double x, double y, double z)
    {

        double average = (x+y+z)/3;
        return average;

    }
    
   

}



