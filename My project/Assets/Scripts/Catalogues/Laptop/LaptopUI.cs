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
        public int page;
        private void Start()
        {
            PageUpdate();
            category = ContainerTypes.Coffin;
        }
        
        public void PageUpdate()
        {
            var containers = GameState.Containers;
            var arrows = Resources.FindObjectsOfTypeAll<LaptopArrow>();
            if (page != 0)
                arrows[0].gameObject.SetActive(true);
            if (page != (containers.Count - 1) / 3)
                arrows[1].gameObject.SetActive(true);
            
            var canvas = GameObject.Find("Canvas");
            foreach (Transform child in canvas.transform) {
                Destroy(child.gameObject);
            }
            var x = -4.7f;
            var y = 3.5f;
            var i = 0;
            var count = 0;
            while (count < 3 && i < containers.Count)
            {
                var container = containers[i];
                i++;
                if (container.Type != category)
                    continue;
                count++;
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
                
                var button = (GameObject)Instantiate(Resources.Load("ShopButton"), canvas.transform);
                button.GetComponent<ShopButton>().Preference = container;
                button.GetComponentInChildren<Text>().text = container.Price + "$";
                button.transform.position = new Vector3(x + 10.3f, y, 0);

                y -= 3;
            }
        }
    }
}