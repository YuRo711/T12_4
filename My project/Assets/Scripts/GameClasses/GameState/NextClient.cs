using System.Collections;
using System.Collections.Generic;
using Clients;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

            if (CurrentCustomer.Name == "Robber")
            {
                GameObject.Find("DoneButton").GetComponentInChildren<Text>().text = "Гнать бабки";
                GameObject.Find("DoneButton").transform.localScale = new Vector3(1, 1.3f, 1);
            }
            else
            {
                GameObject.Find("DoneButton").GetComponentInChildren<Text>().text = "Готово";
                GameObject.Find("DoneButton").transform.localScale = new Vector3(1, 1, 1);
            }
            
            if (CurrentCustomer.Name == "Cultist" || CurrentCustomer.Name == "Robber")
                GameObject.Find("Music").GetComponent<AudioSource>().mute = true;
            else
                GameObject.Find("Music").GetComponent<AudioSource>().mute = false;
        }
    }
}