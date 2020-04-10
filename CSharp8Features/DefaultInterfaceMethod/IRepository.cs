using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features.DefaultInterfaceMethod
{
    interface IRepository<T>
    {
        IEnumerable<T> ReadAll();

        void Delete(Guid id)
        {
            //logic to delete order
            Console.WriteLine($"{this} Delete method called"); 
        }

    }
}
