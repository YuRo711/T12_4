using System.Collections;
using System.Collections.Generic;
using Clients;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public static partial class GameState
    {
        public static void NextClient()
        {
            ServedClientsToday++;
            Tasks = new List<string>();
            if (CustomersToday.Count == ServedClientsToday)
            {
                Paused = true;
                SceneManager.LoadScene("results");
                return;
            }
            CurrentCustomer = CustomersToday[ServedClientsToday];
            PlayerOrder = new PlayerOrder(CurrentCustomer);
            var client = GameObject.Find("Client");
            client.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(CurrentCustomer.Sprite);
            client.GetComponent<Animator>().Play(CurrentCustomer.Name, 0, 0);
            client.GetComponent<DialogueWindow>().talked = false;
            client.GetComponent<ClientSprite>().Appear();
            client.GetComponent<ClientSprite>().appeared = false;
        }
    }
}