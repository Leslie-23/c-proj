using System;
// using program001;

public class Program003
{
    public static void Main(String[] args)
    {
        int sales;
        Console.Write("Sales Made: $");
        sales = Convert.ToInt32(Console.ReadLine());

        if (sales > 5000)
        {
            Console.WriteLine("Commission: " + sales * 0.10);
        }
        else if (sales >= 4000 && sales <= 4999)
        {
            Console.WriteLine("Commission: " + sales * 0.75);
        }
        else if (sales >= 3000 && sales <= 3999)
        {
            Console.WriteLine("Commission: " + sales * 0.50);
        }
        else if (sales >= 2000 && sales <= 2999)
        {
            Console.WriteLine("Commission: " + sales * 0.30);
        }
        else if (sales < 2000)
        {
            Console.WriteLine("Commission: " + sales * 0.0);
        }
        else
        {
            Console.WriteLine("Invalid sales amount!");
        }
        // forced commission
        if (sales > 1000 && sales < 1800)
        {
            Console.WriteLine("Commission: Nothing, lazy SALES employee, trying to sue me. You're fired for making this sales: " + sales);
        }
    }
}

