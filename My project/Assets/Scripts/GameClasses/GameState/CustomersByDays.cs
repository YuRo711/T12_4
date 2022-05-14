using System.Collections.Generic;

namespace Game
{
    public static partial class GameState
    {
        private static List<List<Customer>> customersByDays = new List<List<Customer>>
        {
            new List<Customer>
            {
                new Customer("Sprites/Characters/Harold", "Harold"),
                new Customer("Sprites/Characters/Abigaile", "Abigaile"),
                new Customer("Sprites/Characters/Tyler", "Tyler")
            }
        };
    }
}