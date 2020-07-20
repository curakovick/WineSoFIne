using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WineSoFine.Models;

namespace WineSoFine.ViewModels
{
    public class RandomWineViewModel
    {
        public Wine Wine { get; set; }
        public List<Customer> Customers { get; set; }
    }
}