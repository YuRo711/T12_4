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
                SceneManager.LoadScene(GameState.LastScene);
        }
    }
}