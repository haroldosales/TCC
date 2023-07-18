using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace PetShop.Context;

public class AnimalContext : DbContext
{
    public AnimalContext(DbContextOptions<AnimalContext> options) 
    : base (options)
    {

    }

    public DbSet<Animal> animal {get; set;} = null!;

}


