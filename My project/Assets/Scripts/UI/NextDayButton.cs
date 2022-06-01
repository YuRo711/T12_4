using System;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class NextDayButton : MonoBehaviour
    {
        public void Click()
        {
            if (GameState.Money <= 0)
            {
                SceneManager.LoadScene("game over");
                return;
            }
            if (GameState.Day == 2)
            {
                SceneManager.LoadScene("final score");
                return;
            }
            var timer = GameObject.Find("Timer").GetComponent<Timer>();
            Timer.exists = false;
            Destroy(timer.gameObject);
            GameState.ServedClientsToday = 0;
            GameState.Day++;
            GameState.Score = 0;
            GameState.StartMoney = GameState.Money;
            GameState.Paused = false;
            GameState.Tasks = new List<string>();
            SceneManager.LoadScene("main");
            GameState.CustomersToday = GameState.customersByDays[GameState.Day];
            GameState.CurrentCustomer = GameState.CustomersToday[0];
        }
    }
}