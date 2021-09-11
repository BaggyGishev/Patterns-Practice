using System;
using UnityEngine;

namespace Gisha.PatternsPractice
{
    public class FruitClicker : MonoBehaviour
    {
        [SerializeField] private string achievementName;
        [SerializeField] private int clickCountForAchievement = 10;

        public static event Action<string> OnFruitClicked;

        private int clickCount = 0;

        private void OnMouseDown()
        {
            clickCount++;

            if (clickCount >= clickCountForAchievement)
                OnFruitClicked?.Invoke(achievementName);
        }
    }
}