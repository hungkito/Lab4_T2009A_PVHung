using System;

namespace Part1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        Circle c1 = new Circle(2.45, "Blue", 23);
        Console.WriteLine("Circle before change: " + c1.Tostring());
        //using properties
        c1.PColor = "red";
        c1.PWeight = 2.56;
        Console.WriteLine("Circle after change: " + c1.Tostring());
        Console.ReadLine();
        }
    }
}