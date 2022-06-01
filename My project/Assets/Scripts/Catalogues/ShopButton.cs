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

    private void Start()
    {
        Check();
    }

    public void Buy()
    {
        if (GameState.Money < Preference.Price)
            return;
        GameState.Money -= Preference.Price;
        if (Preference is Container container)
            if (container.Type == ContainerTypes.Coffin)
                GameState.PlayerOrder.Coffin = container;
            else
                GameState.PlayerOrder.Urn = container;
        else if (Preference is Attribute attribute)
            GameState.PlayerOrder.Attributes.Add(attribute);
        Check();
    }

    public void Check()
    {
        var chosen = false;
        var order = GameState.PlayerOrder;
        if (Preference is Container container)
            if (container.Type == ContainerTypes.Coffin && order.Coffin.Type != ContainerTypes.None)
                chosen = true;
            else if (order.Urn.Type != ContainerTypes.None)
                chosen = true;
            
        else if (Preference is Attribute attribute && attribute.Type == AttributeTypes.Gravestone)
                foreach (var a in order.Attributes)
                    if (a.Type == AttributeTypes.Gravestone)
                        chosen = true;
        foreach (var button in FindObjectsOfType<Button>())
            button.enabled = !chosen;
    }
}
