using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDbExample;

namespace LocalDbExample.Domain
{
    public class CustomerManager
    {
        public static List<DTO.Customer> GetCustomers()  
        {
            var customers = Persistence.CustomersRespository.GetCustomers();
            return customers;
        }

        public static void AddCustomer(DTO.Customer customer)
        {
            try
            {
                Persistence.CustomersRespository.AddCustomer(customer);
            }
            catch (Exception)
            {
                // Log it
                throw;
            }
        }

    }
}
