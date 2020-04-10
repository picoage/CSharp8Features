using System;
using System.Collections.Generic;

namespace CSharp8Features.DefaultInterfaceMethod
{
    public class CustomerRepository : IRepository<Customer>
    {
  
        public IEnumerable<Customer> ReadAll()
        {
            //logic to call customer datastore 

            Console.WriteLine($"{this} ReadAll method called");

            return new List<Customer>(); 
        }
    }
}
