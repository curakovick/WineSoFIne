using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WineSoFine.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter customer's name!")]
        [StringLength (40)]
        [Display(Name ="Name")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "Please enter customer's last name!")]
        [StringLength(40)]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        public WineType WineType { get; set; }

        [Required(ErrorMessage = "Please enter wine type!")]
        [Display(Name ="Wine type")]
        public byte WineTypeId { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "Please enter customer's birthdate!")]
        [Display(Name ="Date of birth")]
        [Min18YearsToOrder]
        public DateTime? Birthdate { get; set; }

    }
}