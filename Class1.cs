using System;

public class Class1
{
    public static void Main(string[] args)
    {

        public Class1()
        {
            Console.Write("Please enter the number of rows:");
            string r1 = Console.ReadLine();
            int r2 = Convert.ToInt32(r1);

            for (int i = 1; i <= r2; i++)
            {
                for (int j = i; j < r2; j++) //printing spaces in decreasing order of rows
                {
                    Console.WriteLine(" ");
                }
                for (int j = 1; j <= i; j++) //printing stars in increasing order
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
