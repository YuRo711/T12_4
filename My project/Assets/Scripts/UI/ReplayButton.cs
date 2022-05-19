using System;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ReplayButton : MonoBehaviour
    {
        private void OnMouseDown()
        {
            SceneManager.LoadScene("main");
            GameState.NextClient();
        }
    }
}