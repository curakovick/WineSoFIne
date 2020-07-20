using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WineSoFine.Models
{
    public class Wine
    {
     
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public WineType Type { get; set; }
        public byte TypeId { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ProducedDate { get; set; }

        public byte NumberInStock { get; set; }


    }
}