using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laptop : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("laptop");
        GameState.LastScene = "laptop";
    }
}
