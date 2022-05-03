using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite activeSprite;
    public Sprite idleSprite;
    private bool activated;

    private void OnMouseOver()
    {
        spriteRenderer.sprite = activeSprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = idleSprite;
    }
}
