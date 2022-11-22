using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(0.0, 1000.0, ErrorMessage = "Il prezzo non può essere negativo")]
        public double Price { get; set; }
        public Pizza()
        {

        }

        public Pizza(string name, string description, string image, double price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
