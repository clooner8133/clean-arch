using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Repositories
{
    public interface ICustomersRepository
    {
        List<Customers> GetAllCustomers();
        Customers GetCustomerById(int customerId);
        bool Insertcustomer(Customers customer);
        bool Updatecustomer(Customers customer);
        bool Deletecustomer(Customers customer);
        bool Deletecustomer(int  customerId);
        void Save();
    }
}
