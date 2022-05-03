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
        private void Start()
        {
            PageUpdate(0);
        }

        private void PageUpdate(int page)
        {
            var containers = GameState.Containers;
            var y = 4;
            var canvas = GameObject.Find("Canvas");
            for (var i = page * 3; i < Math.Min(page * 3 + 3, containers.Count); i++)
            {
                var container = containers[i];
                if (container.Type != ContainerTypes.Coffin)
                    continue;
                
                var sprite = Resources.Load<Sprite>(container.Image);
                if (sprite != null)
                {
                    var image = (GameObject)Instantiate(Resources.Load("ShopImage"), canvas.transform);
                    image.GetComponent<Image>().sprite = sprite;
                    image.transform.position = new Vector3(-5.8f, y, 0);
                }

                var contName = (GameObject)Instantiate(Resources.Load("ShopText"), canvas.transform);
                contName.GetComponent<Text>().text = container.Name;
                contName.transform.position = new Vector3(0, y, 0);
                
                var price = (GameObject)Instantiate(Resources.Load("ShopText"), canvas.transform);
                price.GetComponent<Text>().text = container.Price + "$";
                price.transform.position = new Vector3(3, y, 0);
                
                var button = (GameObject)Instantiate(Resources.Load("ShopButton"), canvas.transform);
                button.GetComponent<ShopButton>().Preference = container;
                button.transform.position = new Vector3(5, y, 0);

                y -= 3;
            }
        }
    }
}