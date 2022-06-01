using System.Collections.Generic;

namespace Game
{
    public static partial class GameState
    {
        public static List<List<Customer>> customersByDays = new List<List<Customer>>
        {
            new List<Customer>
            {
                new Customer("Sprites/Characters/Arataki", "Arataki", "6 sec male"),
                new Customer("Sprites/Characters/Harold", "Harold", "4 sec male"),
                new Customer("Sprites/Characters/Sus 1", "Sus 1", "3 sec male", true),
                new Customer("Sprites/Characters/Tyler", "Tyler", "3 sec male"),
                new Customer("Sprites/Characters/Raven", "Raven", "6 sec female")
            },
            new List<Customer>
            {
                new Customer("Sprites/Characters/Eagle", "Eagle", "7 sec male"),
                new Customer("Sprites/Characters/Sus 2", "Sus 2", "3 sec male", true),
                new Customer("Sprites/Characters/Abigaile", "Abigaile", "7 sec female"),
                new Customer("Sprites/Characters/Milly", "Milly", "6 sec female"),
                new Customer("Sprites/Characters/Robber", "Robber", "3 sec male", true)
            },
            new List<Customer>
            {
                new Customer("Sprites/Characters/Cultist", "Cultist", "cultist", true),
                new Customer("Sprites/Characters/Evelyn", "Evelyn", "5 sec female"),
                new Customer("Sprites/Characters/Sus 3", "Sus 3", "3 sec male", true),
                new Customer("Sprites/Characters/Michel", "Michel", "4 sec male"),
                new Customer("Sprites/Characters/Vampire", "Vampire", "6 sec male")
            }
        };
    }
}