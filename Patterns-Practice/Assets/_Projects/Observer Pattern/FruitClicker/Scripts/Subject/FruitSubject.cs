using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.FruitClicker.Subject
{
    public abstract class FruitSubject : MonoBehaviour
    {
        [SerializeField] private string achievementName;
        [SerializeField] private string audioName;
        
        public string AchievementName => achievementName;
        public string AudioName => audioName;
    }
}