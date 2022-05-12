using System;
using System.Collections;
using Game;
using UnityEngine;

namespace Clients
{
    public class ClientSprite : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            Appear();
        }

        public void Appear()
        {
            StartCoroutine(ChangeColor());
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