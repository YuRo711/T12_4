using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public static partial class GameState
    {
        public static void NextClient()
        {
            ServedClientsToday++;
            Tasks = new List<string>();
            if (CustomersToday.Count == ServedClientsToday)
                return;
            CurrentCustomer = CustomersToday[ServedClientsToday];
            PlayerOrder = new PlayerOrder(CurrentCustomer);
            var client = GameObject.Find("Client");
            client.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(CurrentCustomer.Sprite);
            client.GetComponent<Animator>().Play(CurrentCustomer.Name, 0, 0);
            client.GetComponent<DialogueWindow>().talked = false;
        }
    }
}