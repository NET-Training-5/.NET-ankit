class assignment
{
    public void FindMinAndMAx()
    {
         int[] number= { 89, 9, 18, 67, 23 };
         Console.WriteLine("Maximum number is:" + number.Max());
         Console.WriteLine("Maximum number is:" + number.Min());

    }


    public void Pattern()
    {
        for(int row=1; row <=5; ++row)
        {
            for (int col=1; col<=row; ++col)
            {
                Console.Write("#");

            }
            Console.WriteLine();
        }
      
    }


}