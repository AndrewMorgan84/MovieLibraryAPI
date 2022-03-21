﻿using MovieLibraryAPI.Validations;
using System.ComponentModel.DataAnnotations;

namespace MovieLibraryAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field with name {0} is required")]
        [FirstLetterUppercase]
        public string Name { get; set; }
    }
}