using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Clients;
using Game;
using TMPro;
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
    // Нажатие на клиента
    private void OnMouseDown()
    {
        if (talked || talking)
            return;
        var queue = Dialogues.OrderDict[GameState.CurrentCustomer.Name];
        foreach (var phrase in queue)
            gameObject.GetComponent<DialogueWindow>().dialogueQueue.Add(phrase);
        talking = true;
        GameObject.Find("Voice").GetComponent<AudioSource>().clip = GameState.CurrentCustomer.Voice;
        GameObject.Find("Voice").GetComponent<AudioSource>().Play();
        gameObject.GetComponent<Animator>().speed = 1;
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
            Dialogues.OrderDict[GameState.CurrentCustomer.Name].Remove(line);
        }
        if (!Dialogues.OrderDict[GameState.CurrentCustomer.Name].Any())
            StopTalking();
    }

    private IEnumerator TextUpdate(string[] line)
    {
        gameObject.GetComponent<Animator>().speed = 1;
        currentText = "";
        foreach (var word in line)
        {
            currentText += word;
            canvas = GameObject.Find("Canvas");
            var popup = (GameObject)Instantiate(Resources.Load("Popup"), canvas.transform);
            popup.GetComponentInChildren<TMP_Text>().text = currentText;
            yield return new WaitForSeconds(wordPause);
            Destroy(popup, 3.02f);
            talked = true;
            currentText += " ";
        }
        yield return new WaitForSeconds(wordPause + 0.2f);
    }

    void StopTalking()
    {
        talking = false;
        gameObject.GetComponent<Animator>().speed = 0;
        gameObject.GetComponent<Animator>().Play(GameState.CurrentCustomer.Name, 0, 0);
    }
}