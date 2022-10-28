﻿using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        [Display(Name = "Movie Price")]
        public double Price { get; set; }
        [Display(Name = "Movie Image")]
        public string ImageURL { get; set; }
        [Display(Name = "Movie StartDate")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie EndDate")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Movie Category")]
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
