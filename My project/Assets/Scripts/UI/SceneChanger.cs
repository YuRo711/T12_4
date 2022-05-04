using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string target;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(target);
        GameState.LastScene = target;
    }
}
