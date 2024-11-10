// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the Number guessing game!");
//         Console.WriteLine("1. Take a jab at the guessing game");
//         Console.WriteLine("2. Exit");

//         int choice = Convert.ToInt32(Console.ReadLine());

//         while (choice != 1 && choice != 2)
//         {
//             Console.WriteLine("Invalid choice. Please try again.");
//             choice = Convert.ToInt32(Console.ReadLine());
//         }

//         if (choice == 1)
//         {
//             GuessNumber();
//         }
//         else if (choice == 2)
//         {
//             Console.WriteLine("Goodbye!");
//         }

//     }

//     static void GuessNumber()
//     {
//         Random random = new Random();
//         int number = random.Next(1, 101);
//         int guess;
//         int count = 0;

//         while (true)
//         {
//             Console.WriteLine("Guess a number between 1 and 100:");
//             guess = Convert.ToInt32(Console.ReadLine());
//             count++;

//             if (guess == number)
//             {
//                 Console.WriteLine("Congratulations! You guessed the correct number in " + count + " guesses.");
//                 break;

//             }
//             else if (guess < number)
//             {
//                 Console.WriteLine("Too low. Try again.");
//             }
//             else if (guess > number)
//             {
//                 Console.WriteLine("Too high. Try again.");
//             }

//             Console.WriteLine("Number of guesses: " + count);
//         }
//     }
// }