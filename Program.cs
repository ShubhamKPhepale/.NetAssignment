using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAss
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Sammy", 50000, 10);
            Console.WriteLine(o1.Ename + " "  + " " + o1.Basic + " " + o1.DeptNo);
            Console.WriteLine(o1.GetNetsalary());
            Console.ReadLine();

            Employee o2 = new Employee("Sandy", 60000);
            Console.WriteLine(o2.Ename + " " + o2.Empno + " " + o2.Basic);
            Console.WriteLine(o2.GetNetsalary());
            Console.ReadLine();




            Employee o3 = new Employee("Logan");
            Console.WriteLine(o3.Ename + " " + o3.Empno);
            Console.WriteLine(o3.GetNetsalary());
            Console.ReadLine();


            Employee o4 = new Employee();
            Console.WriteLine(o4.Empno);
            Console.WriteLine(o4.GetNetsalary());
            Console.ReadLine();

            Console.WriteLine(o4.Empno);
            Console.WriteLine(o3.Empno+" "+o3.Ename);
            Console.WriteLine(o2.Empno + " " + o2.Ename + " " + o2.Basic);
            Console.WriteLine(o1.Empno + " " + o1.Ename + " " + o1.Basic + " " + o1.DeptNo);

            Console.ReadLine();
        }
    }
    class Employee
    {
        string ename;

        static int lastempno=0;
        int empno;
        decimal basic;
        short deptno;

        public decimal GetNetsalary()
        {
            decimal netsal;
            netsal = basic + (basic/100);

            return netsal;
        }

        public string Ename
        {

            set
            {
                if (value == "")
                {
                    Console.WriteLine("Employee name cann't be null!!!");
                }
                else
                {
                    ename = value;
                }
            }
            get
            {
                return ename;
            }
        }

        public int Empno
        {
            get;

        }

        public decimal Basic
        {
            set
            {
                if (value >= 50000 && value <= 100000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("salary should be in range");
                }
            }
            get
            {
                return basic;
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("Department cannot be zero");
                }
            }
            get
            {
                return deptno;
            }
        }

        public Employee(string name, decimal basic, short deptno)
        {

            this.Ename = name;
            empno = ++lastempno;
            this.Empno += empno;
            this.Basic = basic;
            this.DeptNo = deptno;
        }
        public Employee(string name, decimal basic)
        {
            this.Ename = name;
            empno = ++lastempno;
            this.Empno += empno;
            this.Basic = basic;
        }

        public Employee(string name)
        {
            this.Ename = name;
            empno = ++lastempno;
            this.Empno += empno;

        }

        public Employee()
        {
            empno = ++lastempno;
            this.Empno += empno;
        }
    }
}
