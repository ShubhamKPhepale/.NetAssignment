using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program6_1
    {
        public delegate decimal SimpleInterest(decimal P, decimal N, decimal R);
        static void Main(string[] args)
        {
            SimpleInterest s = (P, N, R) =>
            {

                return P * R * N / 100;
            };

            Console.WriteLine("Enter P :");
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter N : ");
            decimal year= decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter R : ");
            decimal rate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Simple Interest is : " + s(principal,year, rate));

            Console.ReadLine();
        }
    }
}
