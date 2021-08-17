using System;

namespace LinecomputationOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomr to line computation using oops concept");
            Program ln = new Program();
            Program ln2 = new Program();
            double ll = ln.Length(4, 5, 5, 9);
            double ll2 = ln.Length(4, 8, 5, 9);
            Console.WriteLine("Length of the line" + " " + ll);
            Console.WriteLine("Length of the line 2 is  " + " " + ll2);
            //Console.WriteLine("is lenth of two lines equal " + ll.Equals(ll2));
            Console.WriteLine("comparision of lines " + ll.CompareTo(ll2));

        }
        public double Length(int x1, int x2, int y1, int y2)
        {
            double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return l;
        }
    }
}
