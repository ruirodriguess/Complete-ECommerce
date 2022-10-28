﻿using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        //[Required(ErrorMessage = "Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        //[Required(ErrorMessage = "Required")]      
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        //[Required(ErrorMessage = "Required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
