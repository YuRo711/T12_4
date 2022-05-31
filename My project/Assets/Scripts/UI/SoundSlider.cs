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
                GetComponent<Slider>().value = VoicePlayer.voiceVolume;
            else
            {
                source = GameObject.Find("Music").GetComponent<AudioSource>();
                GetComponent<Slider>().value = source.volume;
            }
        }

        public void ChangeVolume()
        {
            if (isVoice)
                VoicePlayer.voiceVolume = GetComponent<Slider>().value;
            else
                source.volume = GetComponent<Slider>().value;
        }
    }
}