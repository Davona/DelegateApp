using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        delegate bool IsEqual(int x);
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int result1 = Sum(integers, x => x > 5);
            Console.WriteLine(result1);
            int result2 = Sum(integers, x => x % 2 == 0);
            Console.WriteLine(result2);
            int result3 = Sum(integers, x => x % 2 != 0);
            Console.WriteLine(result3);
            int result4 = Sum(integers, x => x < 8);
            Console.WriteLine(result4);
            int result5 = Sum(integers, x => x * x < 9);
            Console.WriteLine(result5);
            CoffeeMaker coffee = new CoffeeMaker(10);
            coffee.RegisterHandler(new CoffeeMaker.CoffeeMakerStateHandler(Show_Message));
            coffee.Prepare(1);

            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};


            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            var square = numbers.Select(x => x * x);

            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            Console.Read();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
        private static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
    }
}
