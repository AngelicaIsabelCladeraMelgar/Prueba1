using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba1.Models
{
    public enum CategoryType
    { 
        place1 = 10,
        place2 = 20,
        place3 = 30,
        place4 = 40,
        place5 = 50,
    }
    public class Cladera
    {
        [Key]
        public int CladeraID { get; set; }


        [StringLength(24,ErrorMessage = "The field {0} must contain betwen {2} and {1} characters",MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Nombre Completo")]
        public string FriendofCladera { get; set; }

        [Required]
        public CategoryType Place { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Cumpleaños")]
        public DateTime Birthdate { get; set; }

    }
}