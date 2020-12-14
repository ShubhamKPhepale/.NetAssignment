using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_3
{
    class Program6_3
    {
        public delegate decimal GetBasic(decimal basic);
        static void Main(string[] args)
        {
            GetBasic g = (basic) =>
            {
                return basic;
            };

            Console.WriteLine("Basic salary is : " + g(25000));

            Console.ReadLine();
        }
    }
}
