using System;

namespace vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome to my number guessing game! ");
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int max_num = Convert.ToInt32(input);

            int random_num = random.Next(0, max_num);
            int count = 0;
            int attempt = 0;
            Console.WriteLine("--You'll have a maximum number of 3 guesses in total--");

            while(true)
            {
                count += 1;
                attempt += 1;
                Console.Write("Make a guess between 0 to " + max_num + " (Attempt: " + attempt + "): ");
                string answer = Console.ReadLine();
                int guess = Convert.ToInt32(answer);

                if (guess == random_num)
                {
                    Console.WriteLine("You've got it correct in " + count + " guesses! ");
                    break;
                } 
                else if (count >= 3)
                {
                    Console.WriteLine("Game over! ");
                    break;
                } 
                else if (guess > max_num)
                {
                    Console.WriteLine("*Enter a number below than " + max_num + "*");
                    count = 0;
                    attempt = 0;
                } 
                else 
                {
                    Console.WriteLine("You've got it incorrect:/");
                }
            }
        }
    }
}