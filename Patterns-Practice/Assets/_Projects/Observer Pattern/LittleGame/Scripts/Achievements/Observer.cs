using System.Collections.Generic;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void OnNotify(object value, NotificationType notificationType);
    }

    public class Subject : MonoBehaviour
    {
        private List<Observer> _observers = new List<Observer>();

        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        protected void Notify(object value, NotificationType notificationType)
        {
            foreach (var observer in _observers)
                observer.OnNotify(value, notificationType);
        }
    }

    public enum NotificationType
    {
        AchievementUnlocked
    }
}