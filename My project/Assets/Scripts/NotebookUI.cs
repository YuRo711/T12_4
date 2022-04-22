﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace DefaultNamespace 
{
    public class NotebookUI : MonoBehaviour
    {
        private GUIStyle style;

        private void Start()
        {
            style = GUIStyle.none;
            style.fontSize = 50;
            style.normal.textColor = Color.black;
        }

        private void OnGUI()
        {
            var y = 140;
            foreach (var task in ClickableText.tasks)
            {
                var textArea = new Rect(550, y, 300, 100);
                GUI.Label(textArea, task, style);
                y += 80;
            }
        }
    }
}