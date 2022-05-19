using System.Collections.Generic;
using Game;
using UnityEngine;

namespace Clients
{
    public class Police : MonoBehaviour
    {
        public void Start()
        {
            if (GameState.CurrentCustomer.Name != "Cop")
                return;
            Debug.Log("Call");
            GetComponent<ClientSprite>().appeared = false;
            GetComponent<ClientSprite>().Appear();
            
            GetComponent<DialogueWindow>().talked = false;
            if (GameState.CurrentCustomer.Criminal)
            {
                Dialogues.OrderDict["Cop"] = new string[]
                {
                    "Благодарим за поимку опасного преступника!",
                    "Вам полагается вознаграждение в 100$"
                };
                GameState.Money += 100;
            }
            else
            {
                Dialogues.OrderDict["Cop"] = new string[]
                {
                    "Ложный вызов. Вы оштрафованы на 50$"
                };
                GameState.Money -= 50;
                if (GameState.Money < 0)
                    GameState.GameOver();
            }
        }
    }
}