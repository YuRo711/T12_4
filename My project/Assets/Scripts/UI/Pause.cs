using System.Collections;
using System.Collections.Generic;
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
        gameObject.SetActive(false);
        SceneManager.LoadScene("menu");
    }
}
