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
        public Customer(string sprite, string name = "Unnamed", string voice = "5 sec female", bool criminal = false)
        {
            Name = name;
            Sprite = sprite;
            Criminal = criminal;
            Voice = Resources.Load<AudioClip>("Voices/" + voice);
            Order = CustomersDict.Orders[name];
        }

        public string Name { get; set; }
        public string Sprite { get; set; }
        public bool Criminal { get; set; }
        public AudioClip Voice { get; set; }

        public CustomerOrder Order { get; set; }
    }
}