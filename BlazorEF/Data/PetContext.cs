using Microsoft.EntityFrameworkCore;

namespace BlazorEF.Data
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options)
        {

        }

        public DbSet<Pet> MyPets => Set<Pet>();
    }
}