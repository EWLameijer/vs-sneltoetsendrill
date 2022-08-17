namespace BugShop.Domain.Interfaces;

public interface IBugService
{
    Bug Get(int id);

    IEnumerable<Bug> Get();
}
