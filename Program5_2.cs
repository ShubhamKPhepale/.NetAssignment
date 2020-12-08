using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program5_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employee you want to enter : ");
            int size = int.Parse(Console.ReadLine());
            Employee[] e = new Employee[size];

            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine("\nEnter empno : ");
                int eno = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter empname: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter designation : ");
                string design = Console.ReadLine();

                Console.WriteLine("Enter age : ");
                int age = int.Parse(Console.ReadLine());

                Employee e1 = new Employee(eno, name, design, age);

                e[i] = e1;

            }


            Console.WriteLine("\n************************ Employeee Deatils ******************");

            List<Employee> list = new List<Employee>(e);

            foreach (Employee Emp in list)
            {
                Console.WriteLine(Emp);
            }


            Console.ReadLine();
        }
    }


    public class Employee
    {
        int empno;
        string empname;
        string designation;
        int age;

        public Employee(int empno, string empname, string designation, int age)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.age = age;
        }

        public override string ToString()
        {
            return empno + " " + empname + " " + designation + " " + age;
        }
    }
}
