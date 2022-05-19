using System.Collections;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft;
    public int dayLength;
    private GUIStyle style;
    private static bool exists;
    private Color color;
    private bool blink;

    private void Start()
    {
        DontDestroyOnLoad(this);
        if (!exists)
            exists = true;
        else
            Destroy(gameObject);
        timeLeft = dayLength;
        style = GUIStyle.none;
        style.font = Resources.Load<Font>("F77 Minecraft");
        color = new Color(50, 0, 50);
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

        color = Color.red;
        for (var i = 0; i < 3; i++)
        {
            blink = true;
            yield return new WaitForSeconds(0.5f);
            blink = false;
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void OnGUI()
    {
        if (GameState.Paused || blink)
            return;
        style.normal.textColor = color;
        style.fontSize = 22;
        var textArea = new Rect(630, 358, 300, 100);
        var minutes = timeLeft / 60;
        var seconds = timeLeft % 60;
        var time = minutes + ":";
        if (seconds / 10 == 0)
            time += "0";
        time += seconds;
        GUI.Label(textArea, time, style);
    }
}