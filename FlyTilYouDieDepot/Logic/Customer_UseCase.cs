using FlyTilYouDieDepot.Data;
using FlyTilYouDieDepot.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Logic
{
    public class Customer_UseCase
    {
        FTYDDContext context = new FTYDDContext();

        public Customer CreateCustomers(string firstname, string lastname, string address, string email, string password)
        {
            Customer c = new Customer(firstname, lastname, address, email, password);
            context.Customers.Add(c);

            context.SaveChanges();

            c.BIC = "DEUTDEFFXXX"; // Beispielwert für BIC
            context.SaveChanges();
            return c;

        }

        public bool DeleteCustomer(string email)
        {
            Customer c = context.Customers.Find(email);
            if (c == null)
            {
                return false;
            }
            context.Customers.Remove(c);
            context.SaveChanges();
            return true;
        }

        public void DeleteAllCustomers()
        {
            foreach (Customer c in context.Customers)
            {
                context.Customers.Remove(c);
            }
        }

        public List<Customer> GetAllCustomers() 
        {
            return context.Customers.Include(c => c.Orders).ToList();
        }

        public Customer GetCustomer(string email)
        {
            Customer c = context.Customers.Find(email);
            
            return c;
        }

       /* public void UpdateCustomer(Customer customer, string name, string desc) 
        {
            Order o = new Order(name, desc);

            Customer c = context.Customers.Include(c => c.Orders).FirstOrDefault(c => c.Id == customer.Id);

            c.Orders.Add(o);
        }*/
    }
}
