using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;
using UnityEngine;

namespace Game
{
    public class Customer
    {
        public Customer(string sprite, string name = "Unnamed", bool criminal = false)
        {
            Name = name;
            Sprite = sprite;
            Criminal = criminal;
            Order = CustomersDict.Orders[name];
        }

        public string Name { get; set; }
        public string Sprite { get; set; }
        public bool Criminal { get; set; }

        public CustomerOrder Order { get; set; }
    }
}