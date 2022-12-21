//LINQ - Language Intregated Query

class LINQ
{
    int[] numbers = { 4, 5, 5, 7, 9, 9, 7, 4, 6, 4, 1, 7, 5, 6, 2, 1, 6, 1, 6 };


    public void LearnToQuery()
    {
        //list all even number from "numbers" array
        List<int> evens = new List<int>();                 //imperertive way
        foreach (var num in numbers)                 //imperertive way
        {                 //imperertive way
            if (num % 2 == 0)                 //imperertive way
            {                 //imperertive way
                evens.Add(num);                 //imperertive way
            }
        }
        //Declarative

        var evenNumbers = numbers.Where(num => num % 2 == 0);
        // Console.WriteLine(evenNumbers);
        // foreach (var item in evenNumbers)
        //     Console.Write(item + "");

        Printvalues(evenNumbers, "even number is ");

        //list all odd numbers which are divisible by 3 
        var oddNumbers = numbers.Where(num => num % 2 != 0 && num % 3 == 0);
        // Console.Write("odd number divisible by 3 is");   == tala ko line ra yo eutai ho 
        //     foreach (var item in oddNumbers)
        //     Console.Write(item + "");

        Printvalues(oddNumbers, "odd number divisible by 3 is"); //mathi ko ra yo line same ho ...garne tarika farak ho



        //list alll the which is multiples of 5 and 7 from numbers
        var multipleof5and7 = numbers.Where(x => x % 5 == 0 && x % 7 == 0);
        // Console.Write("multiple of 5 and 7 is ");
        // foreach (var item in multipleof5and7)
        //     Console.WriteLine(item + "");

        //  other way
        Printvalues(multipleof5and7, "multiple of 5 and 7 is");



        //list all items than 100 with trailing 0, from numbers
        var numbersWithTrailing0 = numbers.Where(x => x < 100 && x.ToString().EndsWith("0"));


        //Print squares of all items in numbers array

        var squares = numbers.Select(x => x * x);
        Printvalues(squares, "Squares");

        // print square root of all timems less than 50
        var squarerootlessthan100 = numbers.Where(x => x < 50).Select(x => Math.Sqrt(x).ToString("N2"));
        Printvalues(squarerootlessthan100, "square roots less than 50 is");

        //expression syntax bata same kam gareko
        var squarerootlessthan1001 = from x in numbers
                                     where x < 50
                                     select Math.Sqrt(x);           //mathi ko method syntax sabai
                                                                    //yo chai expression syntax

        //sort numbers
        var numberssorted = numbers.Order();

        // List 5 items and skipping first two
        var fiveitems = numbers.Skip(2).Take(5);   //skip ra take use gareko inbuit system ho.
        Printvalues(fiveitems, "Skip-Take");

        //Check if any items is even numbers.
        var checkedItemforEvenNumber = numbers.Any(x => x % 2 == 0);  // any - inbuilt system
        Console.WriteLine($"Any Even :{checkedItemforEvenNumber}");

        //Check if all items are even numbers.
        var areAllEvenNumbers = numbers.All(x => x % 2 == 0); //all - inbuilt system
        Console.WriteLine($"Any Even :{areAllEvenNumbers}");




    }

    // public void LearnToQueryOnObjectCollection()
    // {
    //     Person p1 = new();
    //     p1.fullName = "Ankit Dhungana";
    //     p1.gender = 'M';
    //     p1.height = 170.45f;

    //     Person p2 = new() { fullName = "Sasmit Khanal", gender = 'M', height = 45.3f }; // object banaune arko tarika 
    //     Person p3 = new() { fullName = "Ram Shrestha", gender = 'M', height = 65.3f };
    //     Person p4 = new() { fullName = "Sita Kumari", gender = 'F', height = 5565.3f };
    //     Person p5 = new() { fullName = "Rita Humagain", gender = 'F', height = 455.3f };


    //     List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };


    //     // people.Add(p1);
    //     // people.Add(p2);
    //     // people.Add(p3);
    //     // people.Add(p4);
    //     // people.Add(p5);


    //     //List all females
    //     var females = people.Where(x => x.gender == 'F'); //.gender use gareko

    //     //List all males in ascending order of their height
    //     var males = from p in people
    //                 where p.gender == 'M'
    //                 orderby p.height
    //                 select p;
                                            
    // }





    void Printvalues<T>(IEnumerable<T> items, string label)
    {

        Console.WriteLine($"\n{label}");
        foreach (var item in items)
            Console.WriteLine(item + "");
    }

    // Create an array containing 20 country names. query this collection to answer following :
    // 1. List all countries starting with letter N.
    // 2. List all countries which have lentght of 4 or less.
    // 3. Convert all countries to uppercase

}