using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program4_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Employee you want to add :");

            int n = int.Parse(Console.ReadLine());

            Employee[] e = new Employee[n];

            for(int i = 0; i < e.Length; i++)
            {
                Console.WriteLine("\nEnter the EmpNo : ");
                int empno = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the EmpName : ");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter the Designation : ");
                string designation = Console.ReadLine();

                Console.WriteLine("\nEnter the Salary : ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Employee e1 = new Employee();

                e1.setEmp(name,empno,designation, salary);

                e[i] = e1;
            }

            Console.WriteLine("\n************************ All Employee Details ************************");

            for(int i = 0; i < e.Length; i++)
            {
                e[i].display();
            }

            Console.WriteLine("\n************************ Employee Details of Higher Salary ************************");
            decimal maxsal = e[0].salary;

            for(int i = 0; i < e.Length; i++)
            {
                if(e[i].salary > maxsal)
                {
                    maxsal = e[i].salary;
                }
            }

            Console.WriteLine("\n Highest Salary  = " + maxsal);

            Console.WriteLine("\n************************ Search Employee ************************");

            Console.WriteLine("\nEnter the EmpNo to be search : ");
            int search = int.Parse(Console.ReadLine());

            for(int i = 0; i < e.Length; i++)
            {
                if(e[i].empno == search)
                {
                    e[i].display();
                }
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string name;
        public int empno;
        public string designation;
        public decimal salary;

        public void setEmp(string name,int empno,string designation,decimal salary)
        {
            this.name = name;
            this.empno = empno;
            this.designation = designation;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("************************ Employee Info ************************");
            Console.WriteLine(empno + " " + name + " " + designation + " " + salary);
        }
    }


}
