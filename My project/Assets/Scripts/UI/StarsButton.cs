using UnityEngine;

namespace Game
{
    public class StarsButton : MonoBehaviour
    {
        public void PressOk()
        {
            foreach (var obj in FindObjectsOfType<SpriteRenderer>())
                if (obj.name == "Star(Clone)")
                    Destroy(obj);
                else
                    obj.color = Color.white;
            GameState.Score += GameState.PlayerOrder.Stars;
            Destroy(gameObject);
        }
    }
}