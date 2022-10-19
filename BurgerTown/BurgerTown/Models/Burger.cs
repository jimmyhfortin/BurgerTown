using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BurgerTown.Models;

public class Burger
{
    [JsonIgnore]
    public int BurgerID { get; set; }
    [Display(Name = "Nom")]
    public string Name { get;  set; }
    [Display(Name = "Prix ($)")]
    public float Price { get;  set; }
    
    [Display(Name = "Végétarienne")]
    public bool Vegetarian { get;  set; }
    [Display(Name = "Ingrédients")]
    public string Ingredient { get;  set; }

    public string[] IngredientList
    {
        get
        {
            if ((Ingredient == null) || (Ingredient.Length == 0))
            {
                return null;
            }
            return Ingredient.Split(", ");
        }
        
    }
}