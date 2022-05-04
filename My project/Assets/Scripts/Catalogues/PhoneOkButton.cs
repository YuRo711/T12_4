using System;
using UnityEngine;

namespace Game
{
    public class PhoneOkButton : MonoBehaviour
    {
        public bool isChosen;
        public Place Place;

        private void OnMouseDown()
        {
            if (Place != null)
                GameState.CurrentOrder.Add(Place);
        }
    }
}