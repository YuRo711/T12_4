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
            GameState.CurrentCustomer = new Customer("Sprites/Characters/Cop", "Cop", "");
        }
    }
}