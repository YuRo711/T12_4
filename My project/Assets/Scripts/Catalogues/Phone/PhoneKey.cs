using System;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class PhoneKey : MonoBehaviour
    {
        public int number;
        private SpriteRenderer spriteRenderer;
        private GameObject dateText;
        private PhoneOkButton OkButton;

        private void Start()
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            OkButton = GameObject.Find("OK").GetComponent<PhoneOkButton>();
            dateText = GameObject.Find("DateText");
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
            if (number < 0)
                return;
            var len = dateText.GetComponent<Text>().text.Length;
            if (len > 4)
                return;
            if (len == 2)
            {
                OkButton.Day = int.Parse(dateText.GetComponent<Text>().text);
                dateText.GetComponent<Text>().text += ".";
            }
            dateText.GetComponent<Text>().text += number;
            if (len == 4)
                OkButton.Month = int.Parse(dateText.GetComponent<Text>().text.Substring(3, 2));
            
        }
    }
}