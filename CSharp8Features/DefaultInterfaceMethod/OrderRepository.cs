using System;
using System.Collections.Generic;

namespace CSharp8Features.DefaultInterfaceMethod
{
   public class OrderRepository : IRepository<Order>
    {
        public IEnumerable<Order> ReadAll()
        {
            //logic to call customer datastore 
            Console.WriteLine($"{this} ReadAll method called");

            return new List<Order>();
        }
    }
}
