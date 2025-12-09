using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Database
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }

      public  DbSet<PizzaSpecial> PizzasDb { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){ 

        } 

    }

}
    
   

