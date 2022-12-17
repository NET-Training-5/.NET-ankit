// Create an array containing 20 country names. query this collection to answer following :
// 1. List all countries starting with letter N.
// 2. List all countries which have lentght of 4 or less.
// 3. Convert all countries to uppercase
class Array
{
    List<string> names = new List<string>{"nepal","usa","bangladesh","australia","canada", "morocco",
                       "hungary","quatar","isreal","pakistan","croatia","france","argentina",
                       "south korea","north korea","mexico","china","russia","portugal","afganistan"};

    public void Assignment()
    {
        var makingupper = names.Where(a => a.ToUpper() == a);
        foreach (var item in makingupper)
            Console.Write(item + "");



            
    }

    public void Count()
    {
      var length = names.Where(b=> b.Length < 4);

        foreach (string country in length)
        Console.WriteLine(country + "");
    //     {
    //         if (country.Length < 4)
    //         {
    //             Console.WriteLine(country);
                
    //         }
            
    //     }
     }

    public void StartFromN ()
    {
      var fromN = names.Where( n=> n.StartsWith("N"));
      foreach(string country0 in fromN)
      {
        Console.WriteLine(country0);
      }
    }



}
