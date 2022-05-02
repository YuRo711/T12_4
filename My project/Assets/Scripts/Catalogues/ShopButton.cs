using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public Container Container;

    public void OnMouseDown()
    {
        if (GameState.Money >= Container.Price)
            GameState.Money -= Container.Price;
    }
}
