using System.Collections;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft;
    public int dayLength = 300;
    private GUIStyle style;
    private static bool exists;

    private void Start()
    {
        DontDestroyOnLoad(this);
        if (!exists)
            exists = true;
        else
            Destroy(gameObject);
        timeLeft = dayLength;
        style = GUIStyle.none;
        style.fontSize = 22;
        StartCoroutine(Tick());
    }

    private IEnumerator Tick()
    {
        while (timeLeft > 0)
        {
            if (!GameState.Paused)
                timeLeft -= 1;
            yield return new WaitForSeconds(1f);
        }
        SceneManager.LoadScene("results");
    }

    private void OnGUI()
    {
        if (GameState.Paused)
            return;
        style.normal.textColor = new Color(50, 0, 50);
        var textArea = new Rect(630, 358, 300, 100);
        var minutes = timeLeft / 60;
        var seconds = timeLeft % 60;
        var time = minutes + ":" + seconds;
        if (seconds == 0)
            time += "0";
        GUI.Label(textArea, time, style);
    }
}