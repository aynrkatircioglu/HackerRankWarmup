using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.ReadLine();
            var ar_temp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(ar_temp, Int32.Parse);
            Console.WriteLine(ar.Sum()); 
        }
    }
}
