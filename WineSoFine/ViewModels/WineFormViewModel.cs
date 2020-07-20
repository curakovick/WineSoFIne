using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WineSoFine.Models;

namespace WineSoFine.ViewModels
{
    public class WineFormViewModel
    {
        public IEnumerable<Type> Types { get; set; }
        public Wine Wine { get; set; }
        public string Name
        {
            get
            {
                if (Wine != null && Wine.Id != 0)
                    return "Edit Wine";
                return "New Wine";
            }
        }
    }
}