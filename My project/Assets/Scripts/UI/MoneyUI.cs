using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Game
{
    public class MoneyUI : MonoBehaviour
    {
        public int money;
        private GUIStyle style;
        private static bool exists;

        private void Start()
        {
            style = GUIStyle.none;
            money = GameState.Money;
            DontDestroyOnLoad(this);
            if (!exists)
            {
                exists = true;
                GameState.Restart();
                if (SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "results"
                                                                 || SceneManager.GetActiveScene().name == "game over")
                    gameObject.GetComponent<SpriteRenderer>().enabled = false;
                else
                    gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
                Destroy(gameObject);
        }

        private void OnGUI()
        {
            if (GameState.Paused)
                return;
            style.normal.textColor = Color.black;
            style.fontSize = 52;
            money = GameState.Money;
            var textArea = new Rect(380,1005, 300, 100);
            GUI.Label(textArea, money.ToString(), style);
        }
    }
}