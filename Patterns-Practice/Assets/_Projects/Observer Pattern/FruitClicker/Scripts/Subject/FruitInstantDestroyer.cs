using System;

namespace Gisha.PatternsPractice.ObserverPattern.FruitClicker.Subject
{
    public class FruitInstantDestroyer : FruitSubject
    {
        public static event Action<FruitSubject> OnFruitDestroyed;

        private void OnMouseDown()
        {
            OnFruitDestroyed?.Invoke(this);
            Destroy(gameObject);
        }
    }
}