using System;
using Game;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Clients
{
    public class DoneButton : MonoBehaviour
    {
        public void Clicked()
        {
            if (GameState.Money <= 0)
            {
                SceneManager.LoadScene("game over");
                GameState.Paused = true;
                return;
            }
            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft == 0)
            {
                SceneManager.LoadScene("results");
                return;
            }
            if (GameState.CurrentCustomer.Name == "Cop")
            {
                GameState.NextClient();
                return;
            }
            
            var dialogueWindow = GameObject.Find("Client").GetComponent<DialogueWindow>();
            if (dialogueWindow.talking)
                return;
            GameState.Paused = true;
            var canvas = GameObject.Find("Canvas");
            var stars = GameState.PlayerOrder.Stars;
            GameState.Score += stars;
            for (int i = 0; i < stars; i++)
            {
                var star = (GameObject)Instantiate(Resources.Load("Star"), canvas.transform);
                star.transform.position = new Vector3(-3f + i * 3f,0,0);
                star.transform.localScale = new Vector3(10, 10, 10);
            }
            for (int i = stars; i < 3; i++)
            {
                foreach (var obj in FindObjectsOfType<SpriteRenderer>())
                    if (obj.gameObject.name != "Star(Clone)")
                        obj.color = Color.gray;
                var star = (GameObject)Instantiate(Resources.Load("Star"), canvas.transform);
                star.transform.position = new Vector3(-3f + i * 3f,0,0);
                star.transform.localScale = new Vector3(10, 10, 10);
                star.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/star empty");
            }
            var button = (GameObject)Instantiate(Resources.Load("StarsButton"), canvas.transform);
            button.transform.position = new Vector3(0,-4f,0);
        }
    }
}