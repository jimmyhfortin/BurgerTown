namespace BurgerTown.Models;

public class Burger
{
    public int BurgerID { get; set; }
    public string Name { get;  set; }
    public float Price { get;  set; }
    public bool Vegetarian { get;  set; }
    public string Ingredient { get;  set; }
}