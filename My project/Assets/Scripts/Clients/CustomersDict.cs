using System;
using System.Collections.Generic;
using Game;
using Attribute = Game.Attribute;

namespace Clients
{
    public static class CustomersDict
    {
        public static Dictionary<string, CustomerOrder> Orders = new Dictionary<string, CustomerOrder>
        {
            {
                "Abigaile", new CustomerOrder(
                    attributes: new List<Attribute>(),
                    deadlines: Tuple.Create(7, 7),
                    placeName: "Крематорий",
                    ritual: RitualTypes.Cremation,
                    style: ContainerStyles.Rich)
            },
            {
                "Harold", new CustomerOrder(
                    attributes: new List<Attribute>
                    {
                        new Attribute(AttributeTypes.Service, null, "Отпевание", 5),
                        new Attribute(AttributeTypes.Gravestone, "Sprites/stone_1", "Кельтский крест", 50)
                    },
                    deadlines: Tuple.Create(9, 9),
                    placeName: "Кладбище св. Терентия",
                    ritual: RitualTypes.Funeral,
                    style: ContainerStyles.Cross)
            },
            {
                "Tyler", new CustomerOrder()
            }
        };
    }
}