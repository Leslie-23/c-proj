using System;
using System.Collections.Generic;
using System.IO;

namespace Comission
{
    class Transaction
    {
        public string Name { get; set; }
        public int Sales { get; set; }
        public double Commission { get; set; }
        public double CommissionDue { get; set; }
        public double Tax { get; set; }
        public double AfterTaxCommission { get; set; }
        public DateTime TransactionDate { get; set; } // New property for timestamp
    }

    internal class Program
    {
        static List<Transaction> history = new List<Transaction>();

        static void Main(string[] args)
        {
            double flatTaxRate = 0.15;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");
                Console.WriteLine("BSCL COMMISSION CALCULATOR");
                Console.WriteLine("--------------------------");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Sales Made: $");
                int sales = Convert.ToInt32(Console.ReadLine());
                while (sales < 0)
                {
                    Console.WriteLine("Invalid sales amount, Try again");
                    Console.Write("Sales Made: $");
                    sales = Convert.ToInt32(Console.ReadLine());
                }

                double commission = 0;
                if (sales > 0 && sales <= 10000)
                {
                    Console.WriteLine("No commission");
                }
                else if (sales > 10000 && sales <= 15000)
                {
                    commission = 0.5;
                }
                else if (sales > 15000 && sales <= 20000)
                {
                    commission = 0.75;
                }
                else
                {
                    commission = 1;
                }
                Console.WriteLine("Commission allocated for your sales ${0} is {1}  ", sales, commission);
                double commissionDue = sales * commission;

                Console.WriteLine("Commission Due: $" + commissionDue);

                double taxAmount = flatTaxRate * commissionDue;
                double afterTaxCommission = commissionDue - taxAmount;

                Console.WriteLine("Tax rate at 15%: " + taxAmount);
                Console.WriteLine("Commission after tax: $" + afterTaxCommission);

                // Adding a new transaction with the date and time
                history.Add(new Transaction
                {
                    Name = name,
                    Sales = sales,
                    Commission = commission,
                    CommissionDue = commissionDue,
                    Tax = taxAmount,
                    AfterTaxCommission = afterTaxCommission,
                    TransactionDate = DateTime.Now // Capture current date and time
                });

                Console.WriteLine("Would you like to view transaction history? (yes/no)");
                string viewHistory = Console.ReadLine().ToLower();

                if (viewHistory == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("------Transaction History-----");
                    Console.ResetColor();

                    foreach (var transaction in history)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Name: {transaction.Name} \n" +
                                          $"Sales: {transaction.Sales}\n" +
                                          $"Commission: {transaction.Commission} \n" +
                                          $"Commission Due: {transaction.CommissionDue} \n" +
                                          $"Tax: {transaction.Tax} \n" +
                                          $"After Tax Amount: {transaction.AfterTaxCommission}\n" +
                                          $"Transaction Date: {transaction.TransactionDate}\n");
                        Console.ResetColor();
                    }
                }

                Console.WriteLine("Would you like to view transaction summary? (yes/no)");
                string viewSummary = Console.ReadLine().ToLower();

                if (viewSummary == "yes")
                {
                    DisplaySummary();
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Would you like to calculate another commission (yes/no)");
                string repeat = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (repeat != "yes")
                {
                    Console.WriteLine("Thanks for using our calculator :)");
                    break;
                }
            }
        }

        static void DisplaySummary()
        {
            double totalSales = 0;
            double totalCommissionDue = 0;
            double totalTax = 0;
            int transactionCount = history.Count;

            foreach (var transaction in history)
            {
                totalSales += transaction.Sales;
                totalCommissionDue += transaction.CommissionDue;
                totalTax += transaction.Tax;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------Summary------");
            Console.WriteLine($"Total Transactions: {transactionCount}");
            Console.WriteLine($"Total Sales: ${totalSales}");
            Console.WriteLine($"Total Commission Due: ${totalCommissionDue}");
            Console.WriteLine($"Total Tax Collected: ${totalTax}");
            Console.ResetColor();
        }
    }
}
