using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManager.Models;

namespace LibraryManager.ViewModels
{
    public class NewUserViewModel
    {
        public User User { get; set; }
        public Employee Employee { get; set; }
    }
}