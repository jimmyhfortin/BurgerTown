using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BurgerTown.Data;
using BurgerTown.Models;
using Microsoft.AspNetCore.Authorization;

namespace BurgerTown.Pages.Admin
{

    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            Console.WriteLine("wowowowowwowoo");
        }
    }
}