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
        public int Day;
        public int Month;
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
                GameState.PlayerOrder.Place = Place;
                GameState.PlayerOrder.Day = Day;
                GameState.PlayerOrder.Month = Month;
                GameState.LastScene = "main";
                SceneManager.LoadScene("main");
            }
        }
    }
}