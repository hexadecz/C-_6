using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6_2
{
    class person
    {
        string ID;
        string name;
        int age;
        string gender;

        public override string ToString()
        {
            return $"person: {name}({age} years old ,{gender})";
        }

        public virtual double CalculateTax()
        {
            return 0;
        }
    }
    class employee: person
    {
        protected double salary;

        public override double CalculateTax()
        {
            return salary * 0.1;
        }
    }

    class SalesMan :employee
    {
        double commission;
        public override double CalculateTax()
        {
            return salary * 0.15 + commission*0.1 ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
