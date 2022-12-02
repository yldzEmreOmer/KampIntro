using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.FirstName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated: " + customer.FirstName);
        }
    }
}
