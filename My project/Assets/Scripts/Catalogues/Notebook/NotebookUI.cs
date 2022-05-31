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
    public class NotebookUI : MonoBehaviour
    {
        private GUIStyle style;

        private void Start()
        {
            style = GUIStyle.none;
            style.fontSize = 50;
            style.normal.textColor = Color.black;
            UpdateTasks();
        }

        private void UpdateTasks()
        {
            var y = 3.3f;
            var canvas = GameObject.Find("Canvas");
            foreach (var task in GameState.Tasks)
            {
                var line = (GameObject)Instantiate(Resources.Load("NotebookText"), canvas.transform);
                line.GetComponent<TMP_Text>().text = task;
                line.transform.position = new Vector3(0, y, 0);
                y -= 0.8f;
            }
        }
    }
}