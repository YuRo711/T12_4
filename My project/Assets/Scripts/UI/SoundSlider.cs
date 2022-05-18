using System;
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
            source = (isVoice)
                ? GameObject.Find("Voices").GetComponent<AudioSource>()
                : GameObject.Find("Music").GetComponent<AudioSource>();
            GetComponent<Slider>().value = source.volume;
        }

        public void ChangeVolume()
        {
            source.volume = GetComponent<Slider>().value;
        }
    }
}