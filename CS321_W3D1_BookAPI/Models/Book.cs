using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W3D1_BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required.")]
        [MaxLength(75, ErrorMessage ="Title must be less than 75")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Category { get; set; }



    }
}
