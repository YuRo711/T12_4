using System.Globalization;
using Clients;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class PoliceButton : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        private void OnMouseEnter()
        {
            spriteRenderer.color = new Color(102, 102, 102);
        }

        private void OnMouseExit()
        {
            spriteRenderer.color = Color.white;
        }

        private void OnMouseDown()
        {
            SceneManager.LoadScene("main");
            GameState.LastScene = "main";
            GameState.FalseCall = !GameState.CurrentCustomer.Criminal;
            if (GameState.CurrentCustomer.Name.StartsWith("Sus"))
            {
                for (var i = GameState.Day + 1; i < 3; i++)
                    foreach (var customer in GameState.customersByDays[i])
                        if (customer.Name.StartsWith("Sus"))
                        {
                            GameState.customersByDays[i].Remove(customer);
                            break;
                        }
            }
            GameState.CurrentCustomer = new Customer("Sprites/Characters/Cop", "Cop", "");
        }
    }
}