using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        var pause = Resources.FindObjectsOfTypeAll<Pause>()[0].gameObject;
        pause.SetActive(true);
        pause.GetComponent<SpriteRenderer>().sprite = pause.GetComponent<ObjectActivation>().idleSprite;
        if (SceneManager.GetActiveScene().name == "menu")
            SceneManager.LoadScene(GameState.LastScene);
        else
        {
            GameState.LastScene = "main";
            SceneManager.LoadScene("main");
        }
    }
}
