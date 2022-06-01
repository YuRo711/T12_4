

using System;
using Clients;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Results : MonoBehaviour
    {
        private GUIStyle style;
        private bool final;

        private void Start()
        {
            GameState.TotalMoney += GameState.Money - GameState.StartMoney;
            GameState.Money -= 100;
            GameState.TotalScore += GameState.Score;
            style = GUIStyle.none;
            style.fontSize = 55;
            style.font = Resources.Load<Font>("F77 Minecraft");
            GameState.Paused = true;
            final = SceneManager.GetActiveScene().name == "final score";
            if (final)
            {
                GameStarted.Started = false;
                GameObject.Find("Music").GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("MementoMori");
                GameObject.Find("Music").GetComponent<AudioSource>().Play();
            }
        }
        private void OnGUI()
        {
            style.normal.textColor = Color.white;
            var x = 300;
            var y = 200;
            var textArea = new Rect(x, y, 600, 100);
            var text = "Всего клиентов обслужено: ";
            text += (final) ? GameState.ServedClientsToday : GameState.ServedClientsTotal;
            GUI.Label(textArea, text, style);
            y += 120;
            
            textArea = new Rect(x, y, 600, 100);
            text = "Денег заработано: ";
            text += GameState.Money - GameState.StartMoney;
            text += "$";
            GUI.Label(textArea, text, style);
            y += 80;

            if (!final)
            {
                textArea = new Rect(x, y, 600, 100);
                text = "(-100$ на аренду офиса)";
                GUI.Label(textArea, text, style);
                y += 100;
                
                textArea = new Rect(x, y, 600, 100);
                text = "Всего денег: ";
                text += GameState.Money;
                text += "$";
                GUI.Label(textArea, text, style);
                y += 120;
            }
            else
            {
                y += 20;
                textArea = new Rect(x, y, 600, 100);
                text = "Чистой прибыли: ";
                text += GameState.TotalMoney;
                text += "$";
                GUI.Label(textArea, text, style);
                y += 120;
            }

            textArea = new Rect(x, y, 600, 100);
            text = "Звёзд получено: ";
            var totalCustomers = 0;
            foreach (var day in GameState.customersByDays)
            {
                totalCustomers += day.Count;
            }
            text += (final) ? 
                GameState.TotalScore + "/" + 3 * totalCustomers :
                GameState.Score + "/" + 3 * GameState.CustomersToday.Count;
            GUI.Label(textArea, text, style);
        }
    }
}