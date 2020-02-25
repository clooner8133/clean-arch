using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acconting.DataLayer.Repositories;
using Acconting.DataLayer.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomersRepository customer = new CustomersRepository();
            var list = customer.GetAllCustomers();
        }
    }
}
