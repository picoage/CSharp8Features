using System;

namespace CSharp8Features
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyMember.ReadOnlyMember rd = new ReadOnlyMember.ReadOnlyMember();
            rd.X = 10;
            rd.Y = 20; 

            Console.WriteLine($"{rd.ToString()}");
            Console.ReadLine(); 
        }
    }
}
