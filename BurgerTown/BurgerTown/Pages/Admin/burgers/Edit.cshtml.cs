using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BurgerTown.Data;
using BurgerTown.Models;

namespace BurgerTown.Pages.Admin.burgers
{
    public class EditModel : PageModel
    {
        private readonly BurgerTown.Data.DataContext _context;

        public EditModel(BurgerTown.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Burger Burger { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Burgers == null)
            {
                return NotFound();
            }

            var burger =  await _context.Burgers.FirstOrDefaultAsync(m => m.BurgerID == id);
            if (burger == null)
            {
                return NotFound();
            }
            Burger = burger;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Burger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BurgerExists(Burger.BurgerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BurgerExists(int id)
        {
          return (_context.Burgers?.Any(e => e.BurgerID == id)).GetValueOrDefault();
        }
    }
}
