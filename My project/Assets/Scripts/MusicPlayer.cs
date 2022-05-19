using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class MusicPlayer : MonoBehaviour
    {
        private static bool exists;

        private void Start()
        {
            DontDestroyOnLoad(this);
            if (!exists)
                exists = true;
            else
                Destroy(gameObject);
            GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("MainTheme");
            GetComponent<AudioSource>().enabled = true;
            GetComponent<AudioSource>().Play();
        }
    }
}