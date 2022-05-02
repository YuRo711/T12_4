using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite activeSprite;
    public Sprite idleSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        spriteRenderer.sprite = activeSprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = idleSprite;
    }
}
