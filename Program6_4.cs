using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_4
{
    class Program6_4
    {
        public delegate bool IsEven(int num);
        static void Main(string[] args)
        {
            IsEven e = (num) =>
            {

                return num % 2 == 0;

            };

            Console.WriteLine("Enter number : ");

            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("IsEven : " + e(no));

            Console.ReadLine();
        }
    }
}
