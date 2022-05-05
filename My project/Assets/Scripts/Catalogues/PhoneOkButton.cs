using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class PhoneOkButton : MonoBehaviour
    {
        public bool isChosen;
        public Place Place;
        public int servicesPrice;

        private void Update()
        {
            if (GameState.Money < Place.Price)
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            else
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }

        private void OnMouseDown()
        {
            if (Place != null)
            {
                GameState.Money -= Place.Price;
                GameState.CurrentOrder.Add(Place);
                GameState.LastScene = "main";
                SceneManager.LoadScene("main");
            }
        }
    }
}