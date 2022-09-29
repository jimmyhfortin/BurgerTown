using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BurgerTown.Data;
using BurgerTown.Models;

namespace BurgerTown.Pages.Admin.burgers
{
    public class DetailsModel : PageModel
    {
        private readonly BurgerTown.Data.DataContext _context;

        public DetailsModel(BurgerTown.Data.DataContext context)
        {
            _context = context;
        }

      public Burger Burger { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Burgers == null)
            {
                return NotFound();
            }

            var burger = await _context.Burgers.FirstOrDefaultAsync(m => m.BurgerID == id);
            if (burger == null)
            {
                return NotFound();
            }
            else 
            {
                Burger = burger;
            }
            return Page();
        }
    }
}
