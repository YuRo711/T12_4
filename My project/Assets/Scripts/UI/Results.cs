

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
            style.fontSize = 22;
            style.font = Resources.Load<Font>("F77 Minecraft");
            GameState.Paused = true;
        }
        private void OnGUI()
        {
            style.normal.textColor = Color.white;
            
            var textArea = new Rect(200, 100, 300, 100);
            var text = "Клиентов обслужено: ";
            text += GameState.ServedClientsToday;
            GUI.Label(textArea, text, style);
            
            textArea = new Rect(200, 150, 300, 100);
            text = "Денег заработано: ";
            text += GameState.Money - GameState.StartMoney;
            text += "$";
            GUI.Label(textArea, text, style);
            
            textArea = new Rect(200, 180, 300, 100);
            text = "(-100$ на аренду офиса)";
            GUI.Label(textArea, text, style);
            
            textArea = new Rect(200, 220, 300, 100);
            text = "Всего денег: ";
            text += GameState.Money;
            text += "$";
            GUI.Label(textArea, text, style);
            
            textArea = new Rect(200, 270, 300, 100);
            text = "Звёзд получено: ";
            text += GameState.Score + "/" + 3 * GameState.CustomersToday.Count;
            GUI.Label(textArea, text, style);
        }
    }
}