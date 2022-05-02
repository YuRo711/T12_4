using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Game;
using TMPro;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickableText : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI text;
    public string s;
    public int n;

    public void OnPointerClick(PointerEventData eventData)
    {
        text = GetComponent<TextMeshProUGUI>();
        var linkIndex = TMP_TextUtilities.FindIntersectingLink(text, eventData.position, Camera.main);
        if (linkIndex == -1)
            return;
        var linkID = text.textInfo.linkInfo[linkIndex].GetLinkID();
        if (!GameState.Tasks.Contains(linkID))
            GameState.Tasks.Add(linkID);
    }
}
