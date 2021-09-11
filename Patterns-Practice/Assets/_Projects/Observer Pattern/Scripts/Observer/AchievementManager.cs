using Gisha.PatternsPractice.ObserverPattern.Subject;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.Observer
{
    public class AchievementManager : MonoBehaviour
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
        }

        private void OnEnable()
        {
            FruitClicker.OnFruitClicked += CallAchievement;
            FruitDestroyer.OnFruitDestroyed += CallAchievement;
        }

        private void OnDisable()
        {
            FruitClicker.OnFruitClicked -= CallAchievement;
            FruitDestroyer.OnFruitDestroyed -= CallAchievement;
        }

        private void CallAchievement(FruitSubject fruit)
        {
            string key = $"achievement-{fruit.achievementName}";

            if (PlayerPrefs.GetInt(key) == 1)
                return;

            PlayerPrefs.SetInt(key, 1);
            Debug.Log($"<color=blue>Achievement Unlocked!</color> <color=yellow>{fruit.achievementName}</color>");
        }
    }
}