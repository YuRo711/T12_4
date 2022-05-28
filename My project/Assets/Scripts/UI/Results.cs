

using System;
using Game;
using UnityEngine;

namespace DefaultNamespace
{
    public class Results : MonoBehaviour
    {
        private GUIStyle style;

        private void Start()
        {
            GameState.Money -= 100;
            style = GUIStyle.none;
            style.fontSize = 55;
            style.font = Resources.Load<Font>("F77 Minecraft");
            GameState.Paused = true;
        }
        private void OnGUI()
        {
            style.normal.textColor = Color.white;
            var x = 300;
            var y = 200;
            var textArea = new Rect(x, y, 600, 100);
            var text = "Клиентов обслужено: ";
            text += GameState.ServedClientsToday;
            GUI.Label(textArea, text, style);
            y += 120;
            
            textArea = new Rect(x, y, 600, 100);
            text = "Денег заработано: ";
            text += GameState.Money - GameState.StartMoney;
            text += "$";
            GUI.Label(textArea, text, style);
            y += 80;
            
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
            
            textArea = new Rect(x, y, 600, 100);
            text = "Звёзд получено: ";
            text += GameState.Score + "/" + 3 * GameState.CustomersToday.Count;
            GUI.Label(textArea, text, style);
        }
    }
}