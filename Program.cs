using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universitet
{
    public class Person
    {
        public virtual void personInfo()
        {
            Console.WriteLine("namnet är kalle");
            Console.WriteLine("Telefonnumber är 1239994234");

        }
    }

    class Student : Person  // Derived class (child) 
    {
        public override void personInfo()
        {
            Console.WriteLine();
            base.personInfo();
            Console.WriteLine("Detta är mitt femte år här");
            Console.WriteLine();
        }

    }
    class Teacher : Person
    {
        public override void personInfo()
        {
            base.personInfo();
            Console.WriteLine("Jag jobbar som lärare");
            Console.WriteLine();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person myPerson = new Person();  
            Person myStudent = new Student();  
            Person myTeacher = new Teacher();  

            myPerson.personInfo();
            myStudent.personInfo();
            myTeacher.personInfo();

            Console.ReadLine();
        }
    }
}
