using System;
using System.Linq;
namespace Lab01aDebuggingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();

        }
        static void StartSequence()
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Please enter a number greater than zero");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[num];
            int[] populated = Populate(userArray);
            int summed = GetSum(populated);
            int product = GetProduct(userArray, summed);
            GetQuotient(product);

            Console.WriteLine($"Your array is size: {userArray.Length}");
            Console.WriteLine($"The numbers in the array are {String.Join(",",userArray)}");

        }

        static int GetSum(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine(sum);
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Please select a number between 1 and 6");
            int rand = Convert.ToInt32(Console.ReadLine());

            int product = sum * array[rand-1];
            return product;
        }

        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine("Please enter a number");
                int divider = Convert.ToInt32(Console.ReadLine());
                decimal quotient = product / divider;
                return quotient;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0");
                return 0;

            }
        }
        static int[] Populate (int[] array)
        {
            
            int num = 0;
            int[] userArray = new int[array.Length];
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Please enter a number: {i+1} of {array.Length}");
                    array[i] = num;
                    num = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch

            {
                Console.WriteLine("Please Try Again And Enter A valid String");
                StartSequence();
            }
            
            return userArray;

        }
    }
}




