﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeForGood.Pages
{
    public class VolunteerModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your volunteer page.";
        }
    }
}