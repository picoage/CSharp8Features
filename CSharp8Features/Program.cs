using System;

namespace CSharp8Features
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                
            }
            ReadOnlyMember.ReadOnlyMember rd = new ReadOnlyMember.ReadOnlyMember();
            rd.X = 10;
            rd.Y = 20; 

            Console.WriteLine($"{rd.ToString()}");
            Console.ReadLine(); 
        }
    }
}
