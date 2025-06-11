using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {

        static void type(string typing, int delay = 30)
        {

            foreach (char message in typing)
            {
                Console.Write(message);
                Thread.Sleep(delay);
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            type("\n Welcome to Delta Quiz.");
            Thread.Sleep(1000);
            type("\n\n First, you'll get a short and simple tutorial. \n\n You'll be given a few questions to solve.\n\n Don't worry if you make a mistake — you'll learn.\n\n At the end, you'll see your score and some feedback.");
            type("\n\n Ready?");
            Thread.Sleep(1000);
            type("\n\n press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine();
            type(" The formula is: delta = b² - 4ac.\n If delta > 0 - two real roots, delta = 0 - one real root, delta < 0 - no real roots..\n\n You're going to answer a few questions.\n Even if you make mistakes, the quiz continues.\n\n At the end, you'll get a score and feedback.\n\n Let’s begin!\n\n press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
            int score = 0;

            Console.WriteLine("Question 1: Solve x² - 5x + 6 = 0");
            Console.Write("Root 1: ");
            string rootOne = Console.ReadLine();
            Console.Write("Root 2: ");
            string rootTwo = Console.ReadLine();

            if ((rootOne == "2" && rootTwo == "3") || (rootOne == "3" && rootTwo == "2"))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("\nQuestion 2: Solve x² + 2x + 1 = 0");
            Console.Write("Root: ");
            string singleRoot = Console.ReadLine();

            if (singleRoot == "-1")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("\nQuestion 3: Solve x² + x + 1 = 0");
            Console.Write("Number of real roots (0, 1 or 2): ");
            string realRootsCount = Console.ReadLine();

            if (realRootsCount == "0")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nYour score: {score}/3");
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (score == 3)
                Console.WriteLine("Excellent!");
            else if (score == 2)
                Console.WriteLine("Good job!");
            else
                Console.WriteLine("Keep practicing!");
            Console.ReadKey();

        }
    }
}
