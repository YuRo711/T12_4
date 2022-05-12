using System;
using UnityEngine;

namespace Game
{
    public class LaptopArrow : MonoBehaviour
    {
        public bool next;
        private LaptopUI ui;

        private void Start()
        {
            ui = GameObject.Find("Laptop UI").GetComponent<LaptopUI>();
        }

        private void Update()
        {
            if (ui.page == 0 && next)
                gameObject.SetActive(false);
        }

        private void OnMouseDown()
        {
            if (next)
                ui.page += 1;
            else
                ui.page -= 1;
            ui.PageUpdate();
        }
    }
}