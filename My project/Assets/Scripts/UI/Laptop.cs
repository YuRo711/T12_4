using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laptop : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("laptop");
    }
}
