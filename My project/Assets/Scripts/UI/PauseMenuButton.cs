using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game
{
    public class PauseMenuButton : MonoBehaviour
    {
        public string buttonName;

        public void OnMouseDown()
        {
            if (buttonName == "exit")
                Application.Quit();
            else if (buttonName == "settings")
            {
                SceneManager.LoadScene("settings");
            }
            else if (buttonName == "continue")
            {
                SceneManager.LoadScene(GameState.LastScene);
                GameState.Paused = false;
                var uiRenderer = GameObject.Find("UI Pause").GetComponent<SpriteRenderer>();
                uiRenderer.color = Color.white;
                uiRenderer.sprite = uiRenderer.gameObject.GetComponent<ObjectActivation>().idleSprite;
            }
            else if (buttonName == "dark")
            {
                GameObject.Find("Text").GetComponent<Text>().text = "Ага, конечно";
            }
            else if (buttonName == "back")
            {
                var scene = (GameStarted.Started) ? "menu" : "start menu";
                SceneManager.LoadScene(scene);
            }
            else if (buttonName == "new game")
            {
                GameStarted.Started = true;
                Destroy(GameObject.Find("Music"));
                MusicPlayer.exists = false;
                Destroy(GameObject.Find("Money UI"));
                MoneyUI.exists = false;
                Destroy(GameObject.Find("Timer"));
                Timer.exists = false;
                GameState.Paused = false;
                SceneManager.LoadScene("tutorial");
            }
        }
    }
}