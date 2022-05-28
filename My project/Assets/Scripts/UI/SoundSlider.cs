using System;
using DefaultNamespace;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class SoundSlider : MonoBehaviour
    {
        public bool isVoice;
        private AudioSource source;

        private void Start()
        {
            if (isVoice)
                VoicePlayer.voiceVolume = source.volume;
            else
                GameObject.Find("Music").GetComponent<AudioSource>().volume = source.volume;
        }

        public void ChangeVolume()
        {
            source.volume = GetComponent<Slider>().value;
        }
    }
}