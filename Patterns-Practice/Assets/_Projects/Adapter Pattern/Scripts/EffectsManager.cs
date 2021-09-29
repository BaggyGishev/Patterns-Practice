using UnityEngine;
using UnityEngine.UI;

namespace Gisha.PatternsPractice.AdapterPattern
{
    public class EffectsManager : MonoBehaviour
    {
        [SerializeField] private Image birdImage;

        [Space] [SerializeField] private Sprite duckSprite;
        [SerializeField] private Sprite turkeySprite;

        private static EffectsManager Instance { get; set; }

        private void Awake()
        {
            Instance = this;
        }

        public static void ShowBirdImage(string bird)
        {
            if (string.Equals(bird, "Duck"))
            {
                Instance.birdImage.sprite = Instance.duckSprite;
                Instance.birdImage.SetNativeSize();
            }
            else if (string.Equals(bird, "Turkey"))
            {
                Instance.birdImage.sprite = Instance.turkeySprite;
                Instance.birdImage.SetNativeSize();
            }
            else
                Debug.LogError("Bird couldn't be found!");
        }
    }
}