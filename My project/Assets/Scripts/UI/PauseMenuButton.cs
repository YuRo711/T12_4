using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class PauseMenuButton : MonoBehaviour
    {
        public string buttonName;

        public void Click()
        {
            if (buttonName == "exit")
                Application.Quit();
            else if (buttonName == "settings")
                SceneManager.LoadScene("settings");
            else if (buttonName == "continue")
            {
                SceneManager.LoadScene(GameState.LastScene);
                GameState.Paused = false;
                var uiRenderer = GameObject.Find("UI Pause").GetComponent<SpriteRenderer>();
                uiRenderer.color = Color.white;
                uiRenderer.sprite = uiRenderer.gameObject.GetComponent<ObjectActivation>().idleSprite;
            }
        }
    }
}