using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Added:")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Released:")]
        public DateTime ReleaseDate { get; set; }
       
        [Display(Name = "Number Available:")]
        [Range(0, 25)]
        public int NumberInStock { get; set; }
    }
}