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
    public class LaptopUI : MonoBehaviour
    {
        public ContainerTypes category;
        private void Start()
        {
            PageUpdate(0);
            category = ContainerTypes.Coffin;
        }
        
        public void PageUpdate(int page)
        {
            var canvas = GameObject.Find("Canvas");
            foreach (Transform child in canvas.transform) {
                Destroy(child.gameObject);
            }
            var containers = GameState.Containers;
            var x = -4.7f;
            var y = 3.5f;
            for (var i = page * 3; i < Math.Min(page * 3 + 3, containers.Count); i++)
            {
                var container = containers[i];
                if (container.Type != category)
                    continue;
                
                var sprite = Resources.Load<Sprite>(container.Image);
                if (sprite != null)
                {
                    var image = (GameObject)Instantiate(Resources.Load("ShopImage"), canvas.transform);
                    image.GetComponent<Image>().sprite = sprite;
                    image.transform.position = new Vector3(x, y, 0);
                }

                var contName = (GameObject)Instantiate(Resources.Load("ShopText"), canvas.transform);
                contName.GetComponent<Text>().text = container.Name;
                contName.transform.position = new Vector3(x + 5.8f, y, 0);
                
                var price = (GameObject)Instantiate(Resources.Load("ShopText"), canvas.transform);
                price.GetComponent<Text>().text = container.Price + "$";
                price.transform.position = new Vector3(x + 8.3f, y, 0);
                
                var button = (GameObject)Instantiate(Resources.Load("ShopButton"), canvas.transform);
                button.GetComponent<ShopButton>().Preference = container;
                button.transform.position = new Vector3(x + 10.3f, y, 0);

                y -= 3;
            }
        }
    }
}