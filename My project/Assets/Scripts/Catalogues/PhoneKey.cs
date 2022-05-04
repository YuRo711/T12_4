using System;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class PhoneKey : MonoBehaviour
    {
        public int number;
        public SpriteRenderer renderer;
        public GameObject dateText;

        private void Start()
        {
            renderer = gameObject.GetComponent<SpriteRenderer>();
            dateText = GameObject.Find("DateText");
        }

        private void OnMouseEnter()
        {
            renderer.color = new Color(102, 0, 102);
        }

        private void OnMouseExit()
        {
            renderer.color = Color.white;
        }

        private void OnMouseDown()
        {
            if (number < 0)
                return;
            var len = dateText.GetComponent<Text>().text.Length;
            if (len > 4)
                return;
            if (len == 2)
                dateText.GetComponent<Text>().text += ".";
            dateText.GetComponent<Text>().text += number;
        }
    }
}