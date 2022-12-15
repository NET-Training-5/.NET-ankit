class Collection
{
    byte [] ages={1,2,3,4,5,6,7};
    void LearnList()
    {
        List<byte> numbers = new List<byte>();
        numbers.Add (23);
        numbers.Add (237);
        numbers.Add (123);
        numbers.Add (23);
        numbers.Remove(237);

        List<string> name = new List<string>() {"Ram", "Hari","Shyam"};

        foreach (var item in name)
        {
        Console.WriteLine(item);
        }
    }

    void LearnDictionary()
    {
        Dictionary<string, long> countryPopulation = new();
        countryPopulation.Add("Nepal",564654);
        countryPopulation.Add("India",21211564654);
        countryPopulation.Add("France",221564654);
        countryPopulation.Add("China",322564654);
        countryPopulation.Add("USA",321564654);
        countryPopulation.Add("France",31564654);
        countryPopulation.Add("Canada",5623214654);
        countryPopulation.Add("Australia",564321654);
        countryPopulation.Remove("China");
    }


}