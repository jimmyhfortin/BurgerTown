using BurgerTown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BurgerTown.Pages;

public class MenuBurgersModel : PageModel
{
    
    private readonly BurgerTown.Data.DataContext _context;

    public MenuBurgersModel(BurgerTown.Data.DataContext context)
    {
        _context = context;
    }

    public IList<Burger> Burger { get;set; } = default!;

    /*public async Task OnGetAsync()
    {
        if (_context.Burgers != null)
        {
            Burger = await _context.Burgers.ToListAsync();
        }
    }*/

    public async Task OnGetAsync()
    {
        Burger = await _context.Burgers.ToListAsync();
    }
    
}