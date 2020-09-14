

namespace Prueba1.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Se debe ingrasear este campo")]
        public CategoryType Place { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

    }
}