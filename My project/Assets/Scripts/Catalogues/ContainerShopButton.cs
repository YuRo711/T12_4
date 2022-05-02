using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ContainerShopButton : MonoBehaviour
{
    public Container Container;

    public void OnMouseDown()
    {
        GameObject.Find("Money UI").GetComponent<MoneyUI>().Buy(Container.Price);
    }
}
