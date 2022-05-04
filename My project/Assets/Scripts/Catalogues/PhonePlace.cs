using UnityEngine;

namespace Game
{
    public class PhonePlace : MonoBehaviour
    {
        public string name;
        public GameObject placeText;

        private void Start()
        {
            placeText = GameObject.Find("DateText");
        }
    }
}