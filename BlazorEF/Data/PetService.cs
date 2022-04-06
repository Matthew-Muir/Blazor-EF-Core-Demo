using Microsoft.EntityFrameworkCore;

namespace BlazorEF.Data
{
    public class PetService : IPetService
    {
        private readonly PetContext _petContext;

        public PetService(PetContext context)
        {
            _petContext = context;
        }

        public List<Pet> Pets { get; set; } = new List<Pet>();

        public async Task GetAll()
        {
            Pets = await _petContext.MyPets.ToListAsync();
        }
    }
}
