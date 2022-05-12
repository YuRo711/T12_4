using System;
using Game;
using UnityEngine;

public class PhoneCheckbox : MonoBehaviour
{
    public Sprite idle;
    public Sprite chosen;
    public Sprite decline;
    public string serviceName;
    public int price;
    private bool isChosen;

    private void OnMouseDown()
    {
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (isChosen)
        {
            spriteRenderer.sprite = idle;
            GameState.Money += price;
            isChosen = false;
        }
        else if (GameState.Money >= price)
        {
            spriteRenderer.sprite = chosen;
            isChosen = true;
            GameState.PlayerOrder.Attributes.Add(new Game.Attribute(AttributeTypes.Service, null, serviceName, price));
            GameState.Money -= price;
            GameObject.Find("OK").GetComponent<PhoneOkButton>().servicesPrice += price;
        }
    }

    private void Update()
    {
        if (!isChosen)
            if (GameState.Money < price)
                gameObject.GetComponent<SpriteRenderer>().sprite = decline;
            else
                gameObject.GetComponent<SpriteRenderer>().sprite = idle;
    }
}