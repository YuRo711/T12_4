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
        private GUIStyle laptopStyle;

        private void Start()
        {
            laptopStyle = GUIStyle.none;
            laptopStyle.fontSize = 40;
            laptopStyle.normal.textColor = Color.black;
        }

        private void OnGUI()
        {
            var containers = GameState.Containers;
            var y = 0;
            var buttons = new List<GameObject> { GameObject.Find("Shop Button") };
            var page = 0;
            for (var i = page * 3; i < page * 3 + 1; i++)
            {
                var container = containers[i];
                if (container.Type != ContainerTypes.Coffin)
                    continue;
                
                var sprite = Resources.Load<Sprite>(container.Image);
                if (sprite != null)
                    GUI.DrawTexture(new Rect(200, y, 100, 100), sprite.texture);
                else
                    Debug.Log("!");
                
                var textArea = new Rect(350, y + 40, 150, 100);
                GUI.Label(textArea, container.Name, laptopStyle);
                
                textArea = new Rect(480, y + 40, 200, 100);
                GUI.Label(textArea, container.Price.ToString() + "$", laptopStyle);
                
                var button = buttons[i];
                button.GetComponent<ShopButton>().Container = container;

                y += 250;
            }
        }
    }
}