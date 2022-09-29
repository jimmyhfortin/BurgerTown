using System.ComponentModel.DataAnnotations;

namespace BurgerTown.Models;

public class Burger
{
    public int BurgerID { get; set; }
    [Display(Name = "Nom")]
    public string Name { get;  set; }
    [Display(Name = "Prix ($)")]
    public float Price { get;  set; }
    
    [Display(Name = "Végétarienne")]
    public bool Vegetarian { get;  set; }
    [Display(Name = "Ingrédients")]
    public string Ingredient { get;  set; }
}