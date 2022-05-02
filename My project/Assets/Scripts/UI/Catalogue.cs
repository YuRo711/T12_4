using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catalogue : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("catalogue");
    }
}
