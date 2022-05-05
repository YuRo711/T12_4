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
        if (SceneManager.GetActiveScene().name != "tutorial")
            if (!GameState.Tasks.Contains(linkID))
                GameState.Tasks.Add(linkID);
        
        var canvas = GameObject.Find("Canvas");
        var moving = (GameObject)Instantiate(Resources.Load("MovingText"), canvas.transform);
        moving.GetComponent<TMP_Text>().text = "<color=red>" + linkID + "</color>";
        moving.transform.position = gameObject.transform.position;
        var destination = GameObject.Find("Notebook").transform.position;
        StartCoroutine(Move(moving, destination));
    }

    private IEnumerator Move(GameObject moving, Vector3 destination)
    {
        var pos = moving.transform.position;
        var dx = (destination.x - pos.x) / 150;
        var dy = (destination.y - pos.y) / 150;
        for (var i = 0; i < 150; i++)
        {
            pos = moving.transform.position;
            moving.transform.position = new Vector3(pos.x + dx, pos.y + dy, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(moving);
    }
}
