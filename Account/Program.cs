using System;
using System.Threading;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User, please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("User, please enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Thanks for logging in!");
            Console.WriteLine();

            Thread.Sleep(5000);
            bool flag = false;

            Console.WriteLine("Do you wish to stay logged in?");

            string option = Console.ReadLine();

            if (option == "Yes" || option == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Enjoy exploring!");
            }
            else if (option == "No" || option == "no")
            {

                Console.WriteLine();
                Console.WriteLine("See you later!");
                Console.WriteLine();
                flag = true;
            }

            if (flag)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Hi again! Please enter your passowrd from before:");
                int counter = 5;
                while (counter > 0)
                {
                    counter--;
                    string input = Console.ReadLine();
                    Console.WriteLine();
                    if (input == password)
                    {
                        Console.WriteLine($"Welcome {name}!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong password!\nYou have {counter} more tries.");
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("This user has attempted too many invalid passwords. Try again later.");
        }
    }
}
