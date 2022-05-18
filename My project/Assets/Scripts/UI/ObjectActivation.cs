using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectActivation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite activeSprite;
    public Sprite idleSprite;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseOver()
    {
        if (GameState.Paused && SceneManager.GetActiveScene().name != "menu")
            return;
        spriteRenderer.sprite = activeSprite;
    }

    private void OnMouseExit()
    {
        if (GameState.Paused && SceneManager.GetActiveScene().name != "menu")
            return;
        spriteRenderer.sprite = idleSprite;
    }
}
