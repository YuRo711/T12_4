using System;
using UnityEngine;

namespace Game
{
    public class CatalogueCategory : MonoBehaviour
    {
        public AttributeTypes type;

        public void OnMouseDown()
        {
            var ui = GameObject.Find("Catalogue UI").GetComponent<CatalogueUI>();
            ui.category = type;
            ui.page = 0;
            ui.PageUpdate();
        }
    }
}