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

        var evenNumbers = numbers.Where(num => num %2==0);
        Console.WriteLine(evenNumbers);

        //list all odd numbers which are divisible by 3 
         var oddNumbers = numbers.Where(num => num %2 !=0 && num % 3 == 0);
    }
}
//