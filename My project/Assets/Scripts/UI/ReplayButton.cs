using System;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ReplayButton : MonoBehaviour
    {
        public void Replay()
        {
            GameState.Money = GameState.StartMoney;
            GameState.ServedClientsToday = 0;
            SceneManager.LoadScene("main");
            GameState.CurrentCustomer = GameState.CustomersToday[0];
            GameState.Paused = false;
        }
    }
}