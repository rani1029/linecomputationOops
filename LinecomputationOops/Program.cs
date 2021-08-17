using System;

namespace LinecomputationOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomr to line computation using oops concept");
            Program ln = new Program();
            double ll = ln.Length(4, 5, 5, 9);

            Console.WriteLine("Length of the line" + " " + ll);

        }
        public double Length(int x1, int x2, int y1, int y2)
        {
            double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return l;
        }
    }
}
