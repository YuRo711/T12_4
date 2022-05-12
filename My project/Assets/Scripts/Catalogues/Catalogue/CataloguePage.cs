using System;
using UnityEngine;

namespace Game
{
    public class CataloguePage : MonoBehaviour
    {
        public bool next;
        private CatalogueUI ui;

        private void Start()
        {
            ui = GameObject.Find("Catalogue UI").GetComponent<CatalogueUI>();
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