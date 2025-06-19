using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Entities
{
    public class Customer
    {


        [Key]
        public string Email { get; set; }
        [Required]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]

        public string Password { get; set; }
        public virtual List<Order> Orders { get; set; } // one-to-many
        public string? IBAN { get; set; }
        public string? BIC { get; set; }


        public Customer(string firstname, string lastname, string address, string email, string password)
        {
            Id = Guid.NewGuid();

            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Email = email;
            Password = password;

        }

        public Customer() { }

        public override bool Equals(object? obj)
        {
            return obj is Customer customer &&
                   customer.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Email, Password);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Email + " " + Password;
        }
    }
}
