using System;
using System.Collections;
using Game;
using UnityEngine;

namespace Clients
{
    public class ClientSprite : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        public static bool Appeared;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            if (!Appeared)
                Appear();
        }

        public void Appear()
        {
            Destroy(GetComponent<PolygonCollider2D>());
            gameObject.AddComponent<PolygonCollider2D>();
            StartCoroutine(ChangeColor());
            Appeared = true;
        }

        private IEnumerator ChangeColor()
        {
            for (float i = 0; i < 257; i++)
            {
                spriteRenderer.color = new Color(i / 256, i / 256, i / 256);
                yield return new WaitForSeconds(0.007f);
            }
        }
    }
}