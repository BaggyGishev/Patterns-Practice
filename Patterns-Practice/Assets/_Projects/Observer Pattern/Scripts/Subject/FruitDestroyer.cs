using System;

namespace Gisha.PatternsPractice.ObserverPattern.Subject
{
    public class FruitDestroyer : FruitSubject
    {
        public static event Action<FruitSubject> OnFruitDestroyed;

        private void OnMouseDown()
        {
            OnFruitDestroyed?.Invoke(this);

            Destroy(gameObject);
        }
    }
}