using System.Linq;
using Gisha.PatternsPractice.ObserverPattern.FruitClicker.Subject;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.FruitClicker.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private Audio[] audioElements;

        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            FruitInstantDestroyer.OnFruitDestroyed += PlayAudio;

            FruitClickerDestroyer.OnFruitClicked += PlayAudio;
            FruitClickerDestroyer.OnFruitDestroyed += PlayAudio;
        }

        private void OnDisable()
        {
            FruitInstantDestroyer.OnFruitDestroyed -= PlayAudio;

            FruitClickerDestroyer.OnFruitClicked -= PlayAudio;
            FruitClickerDestroyer.OnFruitDestroyed -= PlayAudio;
        }

        private void PlayAudio(object obj)
        {
            Audio audio;

            if (obj is FruitSubject fruit)
            {
                // Ищем аудио файл по string идентификатору в FruitSubject.
                audio = audioElements
                    .FirstOrDefault(x => x.AudioName.Equals(fruit.AudioName));
            }

            else
            {
                var audioName = obj as string;

                // Ищем аудио файл по string идентификатору.
                audio = audioElements
                    .FirstOrDefault(x => x.AudioName.Equals(audioName));
            }

            if (audio == null)
            {
                Debug.LogError($"Audio clip could not be find!");
                return;
            }

            _audioSource.clip = audio.AudioClip;
            _audioSource.Play();
        }
    }

    [System.Serializable]
    public class Audio
    {
        [SerializeField] private string audioName;
        [SerializeField] private AudioClip audioClip;

        public string AudioName => audioName;
        public AudioClip AudioClip => audioClip;
    }
}