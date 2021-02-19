using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise #1");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your favorite color: ");
            string color = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your favorite animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(Story(name, color, animal, age));
            Console.WriteLine("\nExercise #2");
            Console.WriteLine($"The sum of 3 and 4 is {Add(3,4)}");
            Console.WriteLine($"The Product of 3 and 4 is {Multiply(3,4)}");
            Console.WriteLine("\nExercise #2 - Bonus");
            Console.WriteLine($"The sum of 1,1,1,2, and 4 is {Sum(1,1,1,2,4)}" );

        }

        public static string Story(string nm, string col, string an, int count)
        {
            return $"{nm} has a farm with {count} {an}'s.\n" +
                $"The funny thing about these {an}'s is that they\n" +
                $"are all {col}.  {nm} sure does have a weird farm!";
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Sum(params int[] nums)
        {
            int total = 0;
            foreach (int x in nums)
                total += x;
            return total;
        }

    }
}
