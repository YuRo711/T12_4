﻿using System;
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
                if (SceneManager.GetActiveScene().name == "menu")
                    gameObject.GetComponent<SpriteRenderer>().enabled = false;
                else
                    gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
                Destroy(gameObject);
        }

        private void OnGUI()
        {
            style.normal.textColor = Color.black;
            style.fontSize = 22;
            money = GameState.Money;
            var textArea = new Rect(230,358, 300, 100);
            GUI.Label(textArea, money.ToString(), style);
        }
    }
}