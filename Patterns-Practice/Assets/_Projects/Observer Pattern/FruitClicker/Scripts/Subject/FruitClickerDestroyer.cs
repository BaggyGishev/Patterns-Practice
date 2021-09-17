using System;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.FruitClicker.Subject
{
    public class FruitClickerDestroyer : FruitSubject
    {
        [SerializeField] private int clickCountForAchievement = 10;
        public static event Action<string> OnFruitClicked;
        public static event Action<FruitSubject> OnFruitDestroyed;

        private int _clickCount = 0;

        private void OnMouseDown()
        {
            _clickCount++;
            OnFruitClicked?.Invoke("Click");

            if (_clickCount >= clickCountForAchievement)
            {
                OnFruitDestroyed?.Invoke(this);
                Destroy(gameObject);
            }
        }
    }
}