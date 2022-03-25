﻿using System;

namespace MovieLibraryAPI.DTOs
{
    public class FilterMoviesDTO
    {
        public int Page { get; set; }

        public int RecordsPerPage { get; set; }

        public PaginationDTO paginationDTO
        {
            get { return new PaginationDTO { Page = Page, RecordsPerPage = RecordsPerPage }; }
        }

        public String Title { get; set; }

        public int GenreId { get; set; }

        public bool InTheaters { get; set; }

        public bool UpcomingReleases { get; set; }
    }
}