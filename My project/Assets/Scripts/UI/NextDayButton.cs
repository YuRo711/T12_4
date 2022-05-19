using System;
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
            var timer = GameObject.Find("Timer").GetComponent<Timer>();
            timer.timeLeft = timer.dayLength;
            GameState.ServedClientsToday = 0;
            GameState.Day++;
            SceneManager.LoadScene("main");
            GameState.CustomersToday = GameState.customersByDays[GameState.Day];
            GameState.CurrentCustomer = GameState.CustomersToday[0];
        }
    }
}