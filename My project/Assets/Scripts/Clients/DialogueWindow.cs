using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
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
    private float wordPause = 0.7f;
    public bool talking;
    public bool talked;

    private void Start()
    {
        StopTalking();
        canvas = GameObject.Find("Canvas");
        currentText = "";
    }

    private void OnMouseDown()
    {
        if (talked)
            return;
        foreach (var phrase in Dialogues.Phrases[GameState.CurrentCustomer.Name])
            gameObject.GetComponent<DialogueWindow>().dialogueQueue.Add(phrase);
        talking = true;
    }

    private void Update()
    {
        if (!GameState.Paused && talking)
        {
            StartCoroutine(PhraseUpdate());
            dialogueQueue = new List<string>();
        }
    }

    private IEnumerator PhraseUpdate()
    {
        foreach (var line in dialogueQueue)
        {
            var words = Regex.Split(line, @"\ (?![^<]*\>)");
            StartCoroutine(TextUpdate(words));
            yield return new WaitForSeconds(wordPause * words.Length);
        }
    }

    private IEnumerator TextUpdate(string[] line)
    {
        currentText = "";
        foreach (var word in line)
        {
            gameObject.GetComponent<Animator>().speed = 1;
            currentText += word;
            canvas = GameObject.Find("Canvas");
            var popup = (GameObject)Instantiate(Resources.Load("Popup"), canvas.transform);
            popup.GetComponentInChildren<TMP_Text>().text = currentText;
            yield return new WaitForSeconds(wordPause);
            Destroy(popup, 3.02f);
            Invoke(nameof(StopTalking), wordPause);
            currentText += " ";
        }
        yield return new WaitForSeconds(wordPause);
    }

    private void StopTalking()
    {
        talking = false;
        talked = true;
        gameObject.GetComponent<Animator>().speed = 0;
        gameObject.GetComponent<Animator>().Play(GameState.CurrentCustomer.Name, 0, 0);
    }
}