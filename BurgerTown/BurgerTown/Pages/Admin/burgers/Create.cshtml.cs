using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BurgerTown.Data;
using BurgerTown.Models;

namespace BurgerTown.Pages.Admin.burgers
{
    public class CreateModel : PageModel
    {
        private readonly BurgerTown.Data.DataContext _context;

        public CreateModel(BurgerTown.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Burger Burger { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Burgers == null || Burger == null)
            {
                return Page();
            }

            _context.Burgers.Add(Burger);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
