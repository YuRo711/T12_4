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
            if (CurrentCustomer.Name == "Cop" || CurrentCustomer.Name == "Cultist" || CurrentCustomer.Name == "Robber")
            {
                GameObject.Find("Music").GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("MainTheme");
                GameObject.Find("Music").GetComponent<AudioSource>().Play();
            }
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
            ClientSprite.Appeared = false;

            if (CurrentCustomer.Name == "Robber")
            {
                GameObject.Find("DoneButton").GetComponentInChildren<Text>().text = "Гнать бабки";
            }
            else
            {
                GameObject.Find("DoneButton").GetComponentInChildren<Text>().text = "Готово";
                GameObject.Find("DoneButton").transform.localScale = new Vector3(1, 1, 1);
            }
            if (CurrentCustomer.Name == "Cultist" || CurrentCustomer.Name == "Robber")
            {
                GameObject.Find("Music").GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Danger");
                GameObject.Find("Music").GetComponent<AudioSource>().Play();
            }

            if (CurrentCustomer.Name == "Oswald" && OswaldCaught)
            {
                CustomersToday.Remove(new Customer("Sprites/Characters/Oswald", "Oswald", "", true));
                ServedClientsToday--;
                NextClient();
            }
        }
    }
}