﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Clients;
using Game;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

class DialogueWindow : MonoBehaviour
{
    public List<string> dialogueQueue;
    private GameObject canvas;
    private string currentText;
    private float wordPause = 1f;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");
        currentText = "";
        var state = DialogueState.Order;
        dialogueQueue = GameState.DialogueQueue;
        foreach (var phrase in Dialogues.Phrases[GameState.CurrentCustomer.Name][state])
            dialogueQueue.Add(phrase);
    }

    private void Update()
    {
        if (!GameState.Paused)
        {
            StartCoroutine(PhraseUpdate());
        }
        dialogueQueue = new List<string>();
    }

    private IEnumerator PhraseUpdate()
    {
        foreach (var line in dialogueQueue)
        {
            var words = line.Split(' ');
            StartCoroutine(TextUpdate(words));
            yield return new WaitForSeconds(wordPause * words.Length);
        }
    }

    private IEnumerator TextUpdate(string[] line)
    {
        currentText = "";
        foreach (var word in line)
        {
            currentText += word;
            canvas = GameObject.Find("Canvas");
            var popup = (GameObject)Instantiate(Resources.Load("Popup"), canvas.transform);
            popup.GetComponentInChildren<TMP_Text>().text = currentText;
            yield return new WaitForSeconds(wordPause);
            //Destroy(popup, wordPause);
            currentText += " ";
        }
        yield return new WaitForSeconds(wordPause);
    }
}