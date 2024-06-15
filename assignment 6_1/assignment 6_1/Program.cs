using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6_1
{

    class point
    {
        private int x;
        private int y;

        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public point()
        {
            X = 0;
            Y = 0;
        }
        public point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        { return base.ToString() + $"\nX-Coordinates={X}\tY-coordinates{Y}"; }
    }

    class circle : point
    {
        public int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public circle()
        {
            Radius = 0;
        }
        public circle(int x, int y, int radius) : base(x, y)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override string ToString()
        { return base.ToString() + $"Radius:{Radius}"; }
    }
  internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

  


  