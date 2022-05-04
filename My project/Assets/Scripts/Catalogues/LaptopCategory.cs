using System;
using UnityEngine;

namespace Game
{
    public class LaptopCategory : MonoBehaviour
    {
        public ContainerTypes type;

        public void OnMouseDown()
        {
            var ui = GameObject.Find("Laptop UI").GetComponent<LaptopUI>();
            ui.category = type;
            ui.PageUpdate(0);
        }
    }
}