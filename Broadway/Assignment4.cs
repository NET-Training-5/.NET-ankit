// /*Think of a real world class with following:

// -Two fields
// -Two properties: one autoimplemented, one write-only
// -A method which prints details of objects of that class*/
class Mobile
{
      string name;
     public DateOnly ManufactureYear;
      string color;

      public string Color {get; set;} //auto implemented


     public long SerialNumber;

     public string Name
     {
        get
        {
            return name;
        }
        set
        {
            if ( value.Length > 2)
            {
                name = value;
            }
        }
     }

    public void PrintDetails()
    {
        var details =$"Brand:{Name}  MFD:{ManufactureYear} Colour{color} Serial Number{SerialNumber}";
        Console.WriteLine(details);
    }


}