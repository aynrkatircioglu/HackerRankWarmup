using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
            var sumOfAllNumbers = 0L;
            var minimumNumber = long.MaxValue;
            var maximumNumber = 0L;
            for (int i = 0; i < 5; i++)
            {
                sumOfAllNumbers += numbers[i];
                if (numbers[i] < minimumNumber)
                    minimumNumber = numbers[i];

                if (numbers[i] > maximumNumber)
                    maximumNumber = numbers[i];

            }

            Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximumNumber, sumOfAllNumbers - minimumNumber));
        }
    }
}
