using UnityEngine;

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
            if (GameState.CurrentCustomer.Criminal)
                Arrest();
            else
            {
                Debug.Log("False call!");
                GameState.Money -= 30;
            }
        }

        private void Arrest()
        {
            Debug.Log("Criminal arrested!");
        }
    }
}