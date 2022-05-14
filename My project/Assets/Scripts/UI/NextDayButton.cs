﻿using System;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class NextDayButton : MonoBehaviour
    {
        private void OnMouseDown()
        {
            GameState.Day++;
            SceneManager.LoadScene("main");
            GameState.NextClient();
        }
    }
}