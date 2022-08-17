using BugShop.Domain.Domain;

namespace BugShop.Domain;

public class Bug
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public HashSet<Ability> Abilities { get; set; }
}
