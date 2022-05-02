using System;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameManager : MonoBehaviour
{
    public static GameObject StateObject;

    private void Start()
    {
        StateObject = GameObject.FindWithTag("GameState");
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
 
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
 
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        StateObject = GameObject.FindWithTag("GameState");
        Debug.Log(StateObject.gameObject.name);
    }
 
}