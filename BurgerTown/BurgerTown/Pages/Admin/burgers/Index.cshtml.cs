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

namespace BurgerTown.Pages.Admin.burgers
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly BurgerTown.Data.DataContext _context;

        public IndexModel(BurgerTown.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Burger> Burger { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Burgers != null)
            {
                Burger = await _context.Burgers.ToListAsync();
            }
        }
    }
}
