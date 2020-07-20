using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WineSoFine.Models;

namespace WineSoFine.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<WineType> WineTypes { get; set; }
        public Customer Customer { get; set; }
    }
}