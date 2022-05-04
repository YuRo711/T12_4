using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class PhonePlace : MonoBehaviour
    {
        public string placeName;
        public int price;
        private GameObject placeText;
        private GameObject priceText;
        private GameObject okButton;

        private void Start()
        {
            placeText = GameObject.Find("PlaceText");
            priceText = GameObject.Find("PriceText");
            okButton = GameObject.Find("OK");
        }

        private void OnMouseEnter()
        {
            placeText.GetComponent<Text>().text = placeName;
            priceText.GetComponent<Text>().text = price + "$";
        }

        private void OnMouseExit()
        {
            if (!okButton.GetComponent<PhoneOkButton>().isChosen)
            {
                placeText.GetComponent<Text>().text = "";
                priceText.GetComponent<Text>().text = "";
            }
            else
            {
                var place = okButton.GetComponent<PhoneOkButton>().Place;
                placeText.GetComponent<Text>().text = place.Name;
                priceText.GetComponent<Text>().text = place.Price + "$";
            }
        }

        private void OnMouseDown()
        {
            okButton.GetComponent<PhoneOkButton>().isChosen = true;
            okButton.GetComponent<PhoneOkButton>().Place = new Place(placeName, price);
        }
    }
}