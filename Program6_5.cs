using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt6_5
{
    class Program6_5
    {
        public delegate bool IsGreaterThan(decimal basic);
        static void Main(string[] args)
        {
            IsGreaterThan g = (basic) =>
            {
                if (basic > 10000)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            Console.WriteLine("Enter Basic : ");

            int Basic = int.Parse(Console.ReadLine());

            Console.WriteLine("IsGreaterThan10000 : " + g(Basic));

            Console.ReadLine();
        }
    }
}
