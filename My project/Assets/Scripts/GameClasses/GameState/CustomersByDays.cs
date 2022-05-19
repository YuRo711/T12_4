using System.Collections.Generic;

namespace Game
{
    public static partial class GameState
    {
        private static List<List<Customer>> customersByDays = new List<List<Customer>>
        {
            // Это для демонстрации
            new List<Customer>
            {
                new Customer("Sprites/Characters/Raven", "Raven"),
                new Customer("Sprites/Characters/Robber", "Robber", "", true),
                new Customer("Sprites/Characters/Milly", "Milly"),
            }
            
            /*
            new List<Customer>
            {
                new Customer("Sprites/Characters/Arataki", "Arataki"),
                new Customer("Sprites/Characters/Harold", "Harold"),
                new Customer("Sprites/Characters/Oswald", "Sus 1", "", true),
                new Customer("Sprites/Characters/Tyler", "Tyler"),
                new Customer("Sprites/Characters/Raven", "Raven")
            },
            new List<Customer>
            {
                //new Customer("Sprites/Characters/Военный", "Военный"),
                new Customer("Sprites/Characters/Oswald", "Sus 2", "", true),
                new Customer("Sprites/Characters/Abigaile", "Abigaile"),
                new Customer("Sprites/Characters/Milly", "Milly"),
                new Customer("Sprites/Characters/Robber", "Robber", "", true)
            },
            new List<Customer>
            {
                new Customer("Sprites/Characters/Cultist", "Cultist", "", true),
                //new Customer("Sprites/Characters/Иностранец", "Иностранец"),
                new Customer("Sprites/Characters/Oswald", "Sus 3", "", true),
                //new Customer("Sprites/Characters/Старушка", "Старушка"),
                new Customer("Sprites/Characters/Vampire", "Vampire")
            }
            */
        };
    }
}