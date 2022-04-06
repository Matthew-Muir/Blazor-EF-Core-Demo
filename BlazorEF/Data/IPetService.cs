
namespace BlazorEF.Data
{
    public interface IPetService
    {
        List<Pet> Pets { get; set; }

        Task GetAll();
    }
}