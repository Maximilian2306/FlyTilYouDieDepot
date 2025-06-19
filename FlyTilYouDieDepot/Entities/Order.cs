using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public string CustomerId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; }
        [Required]
        public virtual Customer Customer { get; set; } // one-to-one

        public virtual Plane Plane { get; set; } // one-to-one

        [ForeignKey(nameof(PlaneId))]
        public Guid PlaneId { get; set; }



        public Order(string customerId , string name, string description)
        {
            Id = Guid.NewGuid();
            
            CustomerId = customerId;
            Name = name;
            Description = description;
                     
        }

        public Order() { }

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   Id == order.Id;
                   
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, CustomerId, Customer, Plane);
        }

        public override string ToString()
        {
            return "Order:" + Id + ". Name:" + Name + ". Desc:" + Description + ". CusId:" + CustomerId;
        }
    }
}
