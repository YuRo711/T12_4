using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        spriteRenderer.sprite = activeSprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = idleSprite;
    }
}
