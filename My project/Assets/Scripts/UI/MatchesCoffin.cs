using System;
using UnityEngine;

namespace Game
{
    public class MatchesCoffin : MonoBehaviour
    {
        public Sprite idleSprite;
        public Sprite activeSprite;

        private void Start()
        {
            if (GameState.MatchesGone)
                Destroy(gameObject);
        }

        private void OnMouseEnter()
        {
            if (GameState.CurrentCustomer.Name == "Milly")
                GetComponent<SpriteRenderer>().sprite = activeSprite;
        }

        private void OnMouseExit()
        {
            GetComponent<SpriteRenderer>().sprite = idleSprite;
        }

        private void OnMouseDown()
        {
            if (GameState.CurrentCustomer.Name == "Milly")
            {
                GameState.PlayerOrder.Coffin = new Container(ContainerTypes.Coffin, style: ContainerStyles.Tiny);
                GameState.MatchesGone = true;
                Destroy(gameObject);
            }
        }
    }
}