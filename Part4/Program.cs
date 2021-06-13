using System;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person personEmployee = new Student("hung", "033686589", "hung@gmail.com", "Business");
            Console.WriteLine(personEmployee.ToString());
        }
    }
}