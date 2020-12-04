using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

            GeneralManager g = new GeneralManager("sammy", 1, 5000, "GM", "none");

            Manager m = new Manager("sandy", 2, 4000, "M");

            Console.WriteLine("***********Manager************");
            Console.WriteLine(m.CalcNetSalary(m.Basic));
            Console.WriteLine("***********General Manager************");
            Console.WriteLine(g.CalcNetSalary(g.Basic));





            Console.ReadLine();

        }
    }
    

        public abstract class Employee
        {

            public Employee(string name = "no", short deptno = 0, decimal Basic = 5000)
            {

                this.EmpName = name;
                this.DeptNumber = deptno;
                this.Basic = Basic;

            }

            public decimal basic;
            public abstract decimal Basic
            {
                get;
                set;
            }
            public static int lastempNo = 0;
            public string name;

            public string EmpName
            {

                set
                {
                    if (value != null)
                    {
                        name = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid name");
                    }

                }

                get
                {

                    return name;

                }

            }

            public int empno;
            public int Empno
            {
                set
                {
                    empno = value;

                }
                get
                {
                    return empno;
                }
            }

            public short deptno;

            public short DeptNumber
            {
                set
                {
                    if (value >= 0)
                    {
                        deptno = value;
                    }

                    else
                    {
                        Console.WriteLine("wrong number");
                    }

                }

                get
                {
                    return deptno;
                }
            }
            public abstract decimal CalcNetSalary(decimal basic);

        }


        public class Manager : Employee
        {

            public Manager(string name = "no", short deptno = 0, decimal Basic = 4000, string design = "Manager") : base(name, deptno, Basic)
            {

                this.Designation = design;

            }

            public string design;

            public string Designation
            {
                set
                {
                    if (value != null)
                    {
                        design = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");

                    }

                }

                get
                {
                    return design;
                }
            }

            public override decimal Basic
            {
                set
                {

                    if (value > 1000 && value < 10000)
                    {
                        basic = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                get
                {
                    return basic;
                }
            }

            public override decimal CalcNetSalary(decimal basic)
            {

                decimal DA = ((basic * 40) / 100);
                decimal HRA = ((basic * 20) / 100);
                decimal Gross_Salary = basic + DA + HRA;

                return Gross_Salary;

            }
        }

        public class GeneralManager : Manager
        {


            public string perks;

            public GeneralManager(string name = "no", short deptno = 0, decimal Basic = 5000, string design = "GM", string perks = "none")

                : base(name, deptno, Basic, design)
            {

                this.Perks = perks;

            }


            public string Perks
            {
                set
                {
                    perks = value;
                }
                get
                {
                    return perks;
                }
            }

        }

        public class CEO : Employee
        {
            public CEO()
            {
                Console.WriteLine("CEO class  construeter");
            }

            public override decimal Basic
            {
                set
                {

                    if (value > 1500 && value < 10000)
                    {
                        basic = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                get
                {
                    return basic;
                }
            }

            public override sealed decimal CalcNetSalary(decimal basic)
            {

                decimal DA = ((basic * 40) / 100);
                decimal HRA = ((basic * 20) / 100);
                decimal Gross_Salary = basic + DA + HRA;

                return Gross_Salary;

            }


        }
}
