using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2
{
    class Program4_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of batches");
            int Batch = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[Batch][];
            for (int i = 0; i < Batch; i++)
            {
                Console.WriteLine("Enter the batch size");
                int Size = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[Size];
            }


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Enter marks for students [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Marks of students {0},{1} is {2}  ", i, j, arr[i][j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
