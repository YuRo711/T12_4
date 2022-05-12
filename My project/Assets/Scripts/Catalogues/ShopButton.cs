using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Attribute = Game.Attribute;

public class ShopButton : MonoBehaviour
{
    public IPreference Preference;

    public void Buy()
    {
        if (GameState.Money >= Preference.Price)
            GameState.Money -= Preference.Price;

        if (Preference is Container container)
            if (container.Type == ContainerTypes.Coffin)
                GameState.PlayerOrder.Coffin = container;
            else
                GameState.PlayerOrder.Urn = container;
        else if (Preference is Attribute attribute)
            GameState.PlayerOrder.Attributes.Add(attribute);
    }
}
