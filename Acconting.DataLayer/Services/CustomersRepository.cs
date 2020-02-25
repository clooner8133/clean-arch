using Acconting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Acconting.DataLayer.Services
{
    public class CustomersRepository : ICustomersRepository
    {
        AccountingDBEntities db = new AccountingDBEntities();
        public bool Deletecustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Deletecustomer(int customerId)
        {
            try
            {
                var res = GetCustomerById(customerId);
                Deletecustomer(res);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool Insertcustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Updatecustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State=EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
