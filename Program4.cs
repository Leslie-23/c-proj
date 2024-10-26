using System;

public class Program004
{
    public static void Main(string[] args)
    {
        Console.WriteLine("** ----------- **");
        Console.WriteLine("** TESTING 123   ");
        Console.WriteLine("** ----------- **");

        int choice;
        do
        {
            Console.WriteLine("\n\n[1] Read Values and Compute");
            Console.WriteLine("[2] Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("How many numbers do you want to enter? ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter number " + (i + 1) + ": ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int evenSum = 0;
                int evenCount = 0;
                int oddCount = 0;
                for (int i = 0; i < size; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenSum += numbers[i];
                        evenCount++;
                    }
                    if (numbers[i] % 2 == 1)
                    {
                        oddCount++;
                    }
                }


                Console.WriteLine("Sum of all even numbers: " + evenSum);
                Console.WriteLine("Count of even numbers: " + evenCount);
                Console.WriteLine("Count of odd numbers: " + oddCount);
            }
            else if (choice != 2)
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        } while (choice != 2);

        Console.WriteLine("Program exited. Thank you!");
    }
}
