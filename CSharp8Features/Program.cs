using CSharp8Features.DefaultInterfaceMethod;
using System;
using System.Diagnostics;

namespace CSharp8Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadOnlyMember readOnlyMember = new ReadOnlyMember {Radius=2 };
            DefaultInterfaceMember(); 
            IndexAndRange.IndexAndRange.Index();
            IndexAndRange.IndexAndRange.Range(); 
            Console.ReadLine();
        }

        static void DefaultInterfaceMember()
        {
            IRepository<Customer> customerRepo = new CustomerRepository();
            customerRepo.ReadAll(); 

            IRepository<Order> orderRepo = new OrderRepository();
            orderRepo.Delete(new Guid());
        }

    }
}
