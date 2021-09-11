using System;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.Subject
{
    public class FruitClicker : FruitSubject
    {
        [SerializeField] private int clickCountForAchievement = 10;
        public static event Action<FruitSubject> OnFruitClicked;
        
        private int _clickCount = 0;

        private void OnMouseDown()
        {
            _clickCount++;

            if (_clickCount >= clickCountForAchievement)
                OnFruitClicked?.Invoke(this);
        }
    }
}