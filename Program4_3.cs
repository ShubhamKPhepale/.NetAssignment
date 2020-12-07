using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_3
{
    class Program4_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Student you want to add :");

            int n = int.Parse(Console.ReadLine());

            Student[] st = new Student[n];

            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine("\nEnter the Student RollNo : ");
                int rollno = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the Student Name : ");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter the Student Marks : ");
                decimal marks = decimal.Parse(Console.ReadLine());

                Student s1 = new Student(rollno,name,marks);

                st[i] = s1;
            }

            Console.WriteLine("\n************************ All Students Details ************************");

            for (int i = 0; i < st.Length; i++)
            {
                st[i].display();
            }

            Console.ReadLine();
        }
    }

    public struct Student
    {
        private string name;
        private int Roll_no;
        private decimal marks;

        public string Sname
        {
            set
            {
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cann't be Empty!!!");
                }
            }

            get
            {
                return name;
            }
        }

        public int SRollno
        {
            set
            {
                if(value > 0)
                {
                    Roll_no = value;
                }
                else
                {
                    Console.WriteLine("Roll no cann't be Empty!!!");
                }
            }

            get
            {
                return Roll_no;
            }
        }

        public decimal Marks
        {
            set
            {
                if(value != null)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Mark cann't be Empty!!!");
                }
            }
            get
            {
                return marks;
            }
        }

        public Student(int RollNo,string Name,decimal Mark):this()
        {
            this.SRollno = RollNo;
            this.Sname = Name;
            this.Marks = Mark;
        }

        public void display()
        {
            Console.WriteLine(SRollno + " " + Sname + " " + " " + Marks);
        }
    }


}
