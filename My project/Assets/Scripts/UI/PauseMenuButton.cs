using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class PauseMenuButton : MonoBehaviour
    {
        public string buttonName;
        private void OnMouseDown()
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