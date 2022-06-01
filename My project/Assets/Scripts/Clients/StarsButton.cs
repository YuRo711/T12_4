using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class StarsButton : MonoBehaviour
    {
        public void PressOk()
        {
            GameState.Score += GameState.PlayerOrder.Stars;
            GameState.Money += GameState.PlayerOrder.Award;
            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft == 0)
            {
                SceneManager.LoadScene("results");
                return;
            }
            foreach (var obj in FindObjectsOfType<SpriteRenderer>())
                if (obj.name == "Star(Clone)")
                    Destroy(obj);
                else
                    obj.color = new Color(0.9888145f, 0.9f, 1f);
            if (GameState.Money <= 0)
            {
                SceneManager.LoadScene("game over");
                GameState.Paused = true;
                return;
            }
            GameState.NextClient();
            GameState.Paused = false;
            Destroy(gameObject);
        }
    }
}