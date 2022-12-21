class Person
{
    // members: methods, fields
    public string fullName;
    public DateTime dob;
    public string address;
    public char gender;
    public float weight;    
    public float height;        

    public double FindAge()
    {
        var ageSpan = DateTime.Now - dob;    
        var ageYears = ageSpan.TotalDays / 365; 
        return ageYears;
    }

    public double FindBMI()
    {
        double heightInMtrs = height / 39.37;
        double bmi = weight / (heightInMtrs * heightInMtrs);
        return bmi;
    }
}