using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class Customer
    {
        public Customer(string sprite, string name = "Unnamed")
        {
            Name = name;
            Sprite = sprite;
        }

        public string Name { get; set; }
        public string Sprite { get; set; }

        public CustomerOrder Order { get; set; }
    }
}