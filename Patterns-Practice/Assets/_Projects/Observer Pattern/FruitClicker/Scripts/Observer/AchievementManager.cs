using Gisha.PatternsPractice.ObserverPattern.FruitClicker.Subject;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.FruitClicker.Observer
{
    public class AchievementManager : MonoBehaviour
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
        }

        private void OnEnable()
        {
            FruitClickerDestroyer.OnFruitDestroyed += CallAchievement;
            FruitInstantDestroyer.OnFruitDestroyed += CallAchievement;
        }

        private void OnDisable()
        {
            FruitClickerDestroyer.OnFruitDestroyed -= CallAchievement;
            FruitInstantDestroyer.OnFruitDestroyed -= CallAchievement;
        }

        private void CallAchievement(FruitSubject fruit)
        {
            string key = $"achievement-{fruit.AchievementName}";

            if (PlayerPrefs.GetInt(key) == 1)
                return;

            PlayerPrefs.SetInt(key, 1);
            Debug.Log($"<color=blue>Achievement Unlocked!</color> <color=yellow>{fruit.AchievementName}</color>");
        }
    }
}