﻿using System;

namespace MovieLibraryAPI.DTOs
{
    public class ActorDTO
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Biography { get; set; }

        public string Picture { get; set; }
    }
}