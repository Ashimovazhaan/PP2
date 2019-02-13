using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        private int yearofstudy;

        class Student
        {
            private string name;
            private string id;
            private int yearofstudy;

            public Student(string name, string id)
            {
                this.name = name;
                this.id = id;
            }
            public void Inc();
            {
            yearofstudy++;
                }
        public int Yearofstudy
        {
            get
            {
                return yearofstudy;
            }
            set
            {
                yearofstudy = value;
            }
        }

        static void Main(string[] args)
        {
            Student st1 = new Student("Aruzhan", "18BD110990");
            st1.yearofstudy = 2018;
            st1.Inc();
            Console.WriteLine(st1.yearofstudy);
            Console.ReadKey();

        }
    }
}
