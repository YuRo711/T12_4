using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class PauseMenuButton : MonoBehaviour
    {
        public string name;
        private void OnMouseDown()
        {
            if (name == "exit")
                Application.Quit();
            else if (name == "settings")
                SceneManager.LoadScene("settings");
            else if (name == "continue")
                SceneManager.LoadScene(GameState.LastScene);
        }
    }
}