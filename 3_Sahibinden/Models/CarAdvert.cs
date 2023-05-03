using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sahibinden.Models
{
    internal class CarAdvert
    {
        [Key]
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public double Price { get; set; }
        public string City { get; set; }

    }
}
