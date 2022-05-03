using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public IPreference Preference;

    public void Buy()
    {
        if (GameState.Money >= Preference.Price)
            GameState.Money -= Preference.Price;
        GameState.CurrentOrder.Add(Preference);
        Debug.Log(Preference.Name);
    }
}
