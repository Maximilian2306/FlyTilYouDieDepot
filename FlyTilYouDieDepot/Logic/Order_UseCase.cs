using FlyTilYouDieDepot.Data;
using FlyTilYouDieDepot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Logic
{
    public class Order_UseCase
    {
        FTYDDContext context = new FTYDDContext();

        public Order CreateOrder(string customerId, string name, string description)
        {
            Order o = new Order(customerId, name, description);
            context.Orders.Add(o);
            context.SaveChanges();
            return o;
        }

        public bool DeleteOrder(string customerId)
        {
            Order o = context.Orders.Find(customerId);
            if(o.CustomerId.Equals(customerId))
            {
                context.Orders.Remove(o);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeleteAllOrders()
        {
            foreach(Order o in context.Orders)
            {
                context.Orders.Remove(o);
            }
            context.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }

        public Order GetOrder(string customerId)
        {
            Order o = context.Orders.Find(customerId);
            return o;

        }
        public void UpdateOrder(Order order)
        {

        }
    }
}
