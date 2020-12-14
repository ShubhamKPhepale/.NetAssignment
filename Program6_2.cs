using System;

namespace Assignment6_2
{
    class Program6_2
    {
        public delegate bool isGreater(int a, int b);
        static void Main(string[] args)
        {
            isGreater g1 = (a, b) =>
            {

                if (a > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            Console.WriteLine(g1(20, 10));

            Console.ReadLine();

        }
    }
}
