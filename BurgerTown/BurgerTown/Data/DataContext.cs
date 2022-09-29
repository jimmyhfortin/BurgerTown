using BurgerTown.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerTown.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Burger> Burgers { get; set; }
}