﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters")]
        public string? FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Bio { get; set;}

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}