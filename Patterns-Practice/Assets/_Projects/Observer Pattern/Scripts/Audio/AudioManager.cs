using Gisha.PatternsPractice.ObserverPattern.Subject;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            FruitDestroyer.OnFruitDestroyed += PlayPopSound;
        }

        private void OnDisable()
        {
            FruitDestroyer.OnFruitDestroyed += PlayPopSound;
        }

        private void PlayPopSound(FruitSubject fruit)
        {
            _audioSource.Play();
        }
    }
}