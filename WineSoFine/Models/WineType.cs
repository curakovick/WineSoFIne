using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WineSoFine.Models
{
    public class WineType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}