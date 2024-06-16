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
            Random rand = new Random();
            int number = rand.Next(0, 100);
            int sum = 0;

            Console.WriteLine($"Случайное число {number}.");

            for (int i = 1; i <= number; i++)
            {
                int remainderThree = i % 3;
                int remainderFive = i % 5;
                bool isRemainder = remainderThree == 0 || remainderFive == 0;

                if (isRemainder == true)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма всех положительных чисел меньше {number} (включая число), которое кратно 3 или 5 равно {sum}");
        }
    }
}
