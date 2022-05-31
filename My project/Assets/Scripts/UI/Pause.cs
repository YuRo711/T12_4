using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private static bool exists;
    void Start()
    {
        DontDestroyOnLoad(this);
        if (!exists)
            exists = true;
        else
            Destroy(gameObject);
    }
    
    private void OnMouseDown()
    {
        GameState.Paused = true;
        SceneManager.LoadScene("menu");
        gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
    }
}
