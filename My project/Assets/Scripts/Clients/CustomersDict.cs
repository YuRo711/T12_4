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
                    deadlines: Tuple.Create(8, 8),
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
                "Tyler", new CustomerOrder(
                    attributes: new List<Attribute>
                        {new Attribute(AttributeTypes.Service, null, "Оркестр", 20)},
                    deadlines: Tuple.Create(13, 20),
                    placeName: "Центральное кладбище",
                    ritual: RitualTypes.Funeral,
                    style: ContainerStyles.None)
            },
            {
                "Raven", new CustomerOrder(
                    deadlines: Tuple.Create(0, 0),
                    placeName: "none",
                    ritual: RitualTypes.Funeral,
                    style: ContainerStyles.Comfort,
                    attributes: new List<Attribute>
                        { new Attribute(AttributeTypes.Wreath, "Sprites/Венок", "Лилии", 10) })
            },
            {
                "Robber", new CustomerOrder()
            },
            {
                "Cop", new CustomerOrder()
            },
            {
                "Milly", new CustomerOrder(
                    ritual: RitualTypes.Funeral,
                    style: ContainerStyles.Tiny,
                    placeName: "none",
                    deadlines: Tuple.Create(0, 0)
                )
            },
            {
                "Cultist", new CustomerOrder(
                    attributes: new List<Attribute>(),
                    deadlines: Tuple.Create(-1, -1),
                    placeName: "Неверно",
                    ritual: RitualTypes.Funeral,
                    style: ContainerStyles.None)
            },
            {"Evelyn", new CustomerOrder(
                    attributes: new List<Attribute>
                    {
                        new Attribute(AttributeTypes.Service, null, "Отпевание", 5),
                        new Attribute(AttributeTypes.Wreath, "Sprites/Венок3", "Овальный", 20)
                    },
                    deadlines: Tuple.Create(0, 0),
                    placeName: "Кладбище св. Терентия",
                    ritual: RitualTypes.Funeral,
                    style: ContainerStyles.Cross)
            },
            {"Eagle", new CustomerOrder(
                attributes: new List<Attribute>
                    { new Attribute(AttributeTypes.Service, null, "Оркестр", 20) },
                deadlines: Tuple.Create(0, 0),
                placeName: "Центральное кладбище",
                ritual: RitualTypes.Funeral,
                style: ContainerStyles.Flag)
            },
            {"Sus 1", new CustomerOrder(
                attributes: new List<Attribute>(),
                deadlines: Tuple.Create(7, 7),
                placeName: "Кладбище св. Терентия",
                ritual: RitualTypes.Funeral,
                style: ContainerStyles.Classic)
            },
            {"Sus 2", new CustomerOrder(
                attributes: new List<Attribute>(),
                deadlines: Tuple.Create(8, 8),
                placeName: "Кладбище св. Терентия",
                ritual: RitualTypes.Funeral,
                style: ContainerStyles.Classic)
            },
            {"Sus 3", new CustomerOrder(
                attributes: new List<Attribute>(),
                deadlines: Tuple.Create(9, 9),
                placeName: "Кладбище св. Терентия",
                ritual: RitualTypes.Funeral,
                style: ContainerStyles.Classic)
            },
            {"Vampire", new CustomerOrder(
                attributes: new List<Attribute>
                {
                    new Attribute(AttributeTypes.Wreath, "Sprites/Венок2", "Сердце", 15),
                    new Attribute(AttributeTypes.Gravestone, "Sprites/stone_2", "Готика", 40)
                },
                deadlines: Tuple.Create(8, 15),
                placeName: "Центральное кладбище",
                ritual: RitualTypes.Funeral,
                style: ContainerStyles.Comfort)
            },
            {"Arataki", new CustomerOrder(
                attributes: new List<Attribute>(),
                deadlines: Tuple.Create(8, 8),
                placeName: "Крематорий",
                ritual: RitualTypes.Cremation,
                style: ContainerStyles.Classic)
            },
            {"Michel", new CustomerOrder(
                attributes: new List<Attribute>
                {
                    new Attribute(AttributeTypes.Service, null, "Оркестр", 20),
                    new Attribute(AttributeTypes.Gravestone, "Sprites/stone_1", "Кельтский крест", 50)
                },
                deadlines: Tuple.Create(9, 12),
                placeName: "Центральное кладбище",
                ritual: RitualTypes.Funeral,
                style: ContainerStyles.Color)
            }
        };
    }
}