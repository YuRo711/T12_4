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
        private static int position;

        private void Start()
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            OkButton = GameObject.Find("OK").GetComponent<PhoneOkButton>();
            dateText = GameObject.Find("DateText");
            position = 0;
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
            var text = dateText.GetComponent<Text>().text.ToCharArray();
            if (position > 4)
                return;
            if (position == 2)
                position++;
            text[position] = Char.Parse(number.ToString());
            dateText.GetComponent<Text>().text = "";
            foreach (var c in text)
                dateText.GetComponent<Text>().text += c;
            if (position == 4)
            {
                OkButton.Day = int.Parse(dateText.GetComponent<Text>().text.Substring(0, 2));
                OkButton.Month = int.Parse(dateText.GetComponent<Text>().text.Substring(3, 2));
            }
            position++;
        }
    }
}