using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Game 
{
    public class CatalogueUI : MonoBehaviour
    {
        public int page;
        public AttributeTypes category;
        private void Start()
        {
            page = 0;
            category = AttributeTypes.Gravestone;
            PageUpdate();
        }

        public void PageUpdate()
        {
            List<Attribute> attributes;
            attributes = (category == AttributeTypes.Gravestone) ? GameState.Gravestones : GameState.Wreaths;;
            var y = 2.5f;
            var x = -6.8f;
            var canvas = GameObject.Find("Canvas");
            foreach (Transform child in canvas.transform) {
                Destroy(child.gameObject);
            }
            for (var i = page * 3; i < Math.Min(page * 3 + 3, attributes.Count); i++)
            {
                var attribute = attributes[i];
                var sprite = Resources.Load<Sprite>(attribute.Image);
                if (sprite != null)
                {
                    var image = (GameObject)Instantiate(Resources.Load("ShopImage"), canvas.transform);
                    image.GetComponent<Image>().sprite = sprite;
                    image.transform.position = new Vector3(x, y, 0);
                    image.transform.localScale = new Vector3(0.8f, 0.8f, 1);
                }

                var contName = (GameObject)Instantiate(Resources.Load("ShopText"), canvas.transform);
                contName.GetComponent<Text>().text = attribute.Name;
                contName.transform.position = new Vector3(x + 4.5f, y + 0.5f, 0);
                
                var button = (GameObject)Instantiate(Resources.Load("ShopButton"), canvas.transform);
                button.GetComponent<ShopButton>().Preference = attribute;
                button.GetComponentInChildren<Text>().text = attribute.Price + "$";
                button.transform.position = new Vector3(x + 5.3f, y - 0.3f, 0);

                y -= 3;
            }
        }
    }
}