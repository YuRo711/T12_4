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
                    deadlines: Tuple.Create(0, 0))
            }
        };
    }
}