﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{    
    public class Movies
    {
        public int ID { get; set; }
        
        [StringLength(60,ErrorMessage = "Min 3  chars, Max 60 chars",MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]

        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
    public class MovieDBContext : DbContext
    {

        public MovieDBContext() : base("MovieDBContext") { }        
        public DbSet<Movies> Movies { get; set; }
    }

}