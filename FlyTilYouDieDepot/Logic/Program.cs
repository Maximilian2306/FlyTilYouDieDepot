using FlyTilYouDieDepot.Data;
using FlyTilYouDieDepot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Logic
{
    public class Program
    {
        FTYDDContext context = new FTYDDContext();

        public void DeleteEverything()
        {
            foreach (Customer c in context.Customers)
            {
                context.Customers.Remove(c);
            }

            foreach (Plane p in context.Planes)
            {
                context.Planes.Remove(p);
            }

            foreach (Order o in context.Orders)
            {
                context.Orders.Remove(o);
            }
            context.SaveChanges();
        }
    }
}
