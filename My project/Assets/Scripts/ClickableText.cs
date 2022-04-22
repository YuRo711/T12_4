using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickableText : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI text;
    public static List<string> tasks = new List<string>();

    public void OnPointerClick(PointerEventData eventData)
    {
        text = GetComponent<TextMeshProUGUI>();
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            var linkIndex = TMP_TextUtilities.FindIntersectingLink(text, eventData.position, null);
            if (linkIndex == -1)
                return;
            var linkID = text.textInfo.linkInfo[linkIndex].GetLinkID();
            if (!tasks.Contains(linkID))
                tasks.Add(linkID);
        }
    }
}
