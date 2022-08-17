using BugShop.Domain;
using BugShop.Domain.Domain;
using BugShop.Domain.Interfaces;

namespace BugShop.Business
{
    public class BugService : IBugService
    {
        private readonly List<Bug> _bugs = new()
        {
            new()
            {
                Id = 1,
                Name = "Bunny",
                Abilities = new()
                {
                    Ability.Sing,
                    Ability.Talk,
                    Ability.Dance,
                    Ability.WreakHavocOnYourEnemies
                }
            },
            new()
            {
                Id = 2,
                Name = "Jiminy-Cricket",
                Abilities = new() { Ability.Talk }
            },
            new()
            {
                Id = 3,
                Name = "NullReference",
                Abilities = new() { Ability.WreakHavocOnYourSoftware }
            }
        };

        public Bug Get(int id) => _bugs.Single(b => b.Id == id);

        public IEnumerable<Bug> Get() => _bugs;
    }
}