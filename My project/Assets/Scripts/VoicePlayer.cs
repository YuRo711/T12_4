using System;
using Game;
using UnityEngine;

namespace DefaultNamespace
{
    public class VoicePlayer : MonoBehaviour
    {
        public static float voiceVolume = 1;
        private void Start()
        {
            GetComponent<AudioSource>().volume = voiceVolume;
        }
    }
}