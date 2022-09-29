using BurgerTown.Data;
using BurgerTown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerTown.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    private DataContext dataContext;

    public PrivacyModel(ILogger<PrivacyModel> logger, DataContext datacontext)
    {
        _logger = logger;
        dataContext = datacontext;
    }

    public void OnGet()
    {
        var burger = new Burger() {Name = "Burger test", Price = 15,Ingredient = "salda",Vegetarian = true};
        dataContext.Burgers.Add(burger);
        dataContext.SaveChanges();
    }
}