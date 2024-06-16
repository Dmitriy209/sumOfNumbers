using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumber = 100;
            int number = random.Next(maxNumber);
            int sum = 0;
            int firstMultiple = 3;
            int secondMultiple = 5;

            Console.WriteLine($"Случайное число {number}.");

            for (int i = 1; i <= number; i++)
            {
                int firstRemainder = i % firstMultiple;
                int secondRemainder = i % secondMultiple;

                if (firstRemainder == 0 || secondRemainder == 0)
                {
                    sum += i;
                }
            }
            
            Console.WriteLine($"Сумма всех положительных чисел меньше {number} (включая число), которое кратно {firstMultiple} или {secondMultiple} равно {sum}");
        }
    }
}
