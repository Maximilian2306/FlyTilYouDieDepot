using FlyTilYouDieDepot.Logic;
using FlyTilYouDieDepot.Data;
using FlyTilYouDieDepot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace FlyTilYouDieDepot;

public class Application
{
    public static void Main ()
    {
        //Customer customers = new Customer ();
        //Customer_UseCase u = new Customer_UseCase();
        //Customer cus = u.CreateCustomers("sijfgh", "izaeughf", "oiazf", "uft", "iugafe");
        Program p = new Program ();
        p.DeleteEverything();
    }
}