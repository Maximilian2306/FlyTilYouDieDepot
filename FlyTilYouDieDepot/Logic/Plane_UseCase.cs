using FlyTilYouDieDepot.Data;
using FlyTilYouDieDepot.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Logic
{
    public class Plane_UseCase
    {
        private FTYDDContext context;


        public Plane_UseCase(FTYDDContext _context)
        {
            context = _context;
        }

        public Plane CreatePlane(string name, string description, int height, int width, int lenght, decimal price, string colour, string imagePath, string digitalData)
        {
            Plane p = new Plane(name, description, height, width, lenght, price, colour, imagePath, digitalData);
            
            //Ausnahme falls Description zu lnag ist

            context.Planes.Add(p);

            context.SaveChanges();
            return p;

        }

        public bool DeletePlane(Guid id)
        {
            Plane p = context.Planes.Find(id);
            if (p != null)
            {
                context.Planes.Remove(p);
                context.SaveChanges();
                return true;
            }
            return false;
            //Ausnahme machen und dem kunden sagen warum löschung fehlgeschlagen ist
        }

        public void DeleteAllPlanes()
        {
            foreach (Plane p in context.Planes)
            {
                context.Planes.Remove(p);
            }
            context.SaveChanges();
        }

        public List<Plane> GetAllPlanes()
        {
            return context.Planes.ToList();
        }

        public Plane GetPlane(Guid id)
        {
            return context.Planes.Find(id);
            
        }
    }
}

