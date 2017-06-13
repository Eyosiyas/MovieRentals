﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        [Required]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }
    }

}