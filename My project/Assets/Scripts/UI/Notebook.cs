using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Notebook : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("notebook");
    }
}
