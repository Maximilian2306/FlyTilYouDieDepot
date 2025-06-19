using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTilYouDieDepot.Entities
{
    public class Plane
    {
        [Key]
     
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Lenght { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Colour { get; set; }
        public bool Guns { get; set; }

        public string ImagePath { get; set; }
        public string DigitalData { get; set; }




        public Plane(string name, string description, int height, int width, int lenght, decimal price, string colour, string imagePath, string digitalData)
        {
            Id = Guid.NewGuid();

            Name = name;
            Description = description;
            Height = height;
            Width = width;
            Lenght = lenght;
            Price = price;
            Colour = colour;
            ImagePath = imagePath;
            DigitalData = digitalData;
        }

        public Plane() { }

        public override bool Equals(object? obj)
        {
            return obj is Plane plane &&
                  plane.Id == Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description, Height, Width, Lenght, Price);
        }

        public override string ToString()
        {
            return Name + " , in " + Colour + ". Gun's: " + Guns + ". Price: " + Price;
        }
    }
}
