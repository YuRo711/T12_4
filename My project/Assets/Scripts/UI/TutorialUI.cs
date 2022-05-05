using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class TutorialUI : MonoBehaviour
    {
        private GameObject popup;
        public string text;
        public void OnMouseEnter()
        {
            var canvas = GameObject.Find("Canvas");
            popup = (GameObject)Instantiate(Resources.Load("Popup"), canvas.transform);
            popup.transform.position = gameObject.transform.position;
            popup.GetComponentInChildren<TMP_Text>().text = text;
        }

        public void OnMouseExit()
        {
            Destroy(popup);
        }

        public void ToGame()
        {
            SceneManager.LoadScene("main");
        }
    }
}