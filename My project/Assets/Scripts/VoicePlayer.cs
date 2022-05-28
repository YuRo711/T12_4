using System;
using Game;
using UnityEngine;

namespace DefaultNamespace
{
    public class VoicePlayer : MonoBehaviour
    {
        public static float voiceVolume;
        private void Start()
        {
            GetComponent<AudioSource>().volume = voiceVolume;
        }
    }
}