using System;
using Game;
using UnityEngine;

namespace DefaultNamespace
{
    public class MusicPlayer : MonoBehaviour
    {
        public static bool exists;

        private void Start()
        {
            DontDestroyOnLoad(this);
            if (!exists)
                exists = true;
            else
                Destroy(gameObject);
            GetComponent<AudioSource>().clip = (GameStarted.Started) ? 
                Resources.Load<AudioClip>("MainTheme") :
                Resources.Load<AudioClip>("MementoMori");
            GetComponent<AudioSource>().enabled = true;
            GetComponent<AudioSource>().Play();
        }
    }
}