using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_3
{
    class Program5_3
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "shubham", "HR", 24);
            Employee e2 = new Employee(2, "sandy", "Manager", 25);
            List<Employee> list = new List<Employee>();

            list.Add(e1);
            list.Add(e2);



            Employee[] e = list.ToArray();

            foreach (Employee Emp in e)
            {
                Console.WriteLine(Emp);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        int empno;
        string name;
        string designation;
        int age;

        public Employee(int empno, string empname, string designation, int age)
        {
            this.empno = empno;
            this.name = empname;
            this.designation = designation;
            this.age = age;
        }

        public override string ToString()
        {
            return empno + " " + name + " " + designation + " " + age;
        }
    }

}
