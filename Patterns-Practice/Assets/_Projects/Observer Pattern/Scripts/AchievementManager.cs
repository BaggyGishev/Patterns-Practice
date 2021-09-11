using System;
using UnityEngine;

namespace Gisha.PatternsPractice
{
    public class AchievementManager : MonoBehaviour
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
        }

        private void OnEnable() => FruitClicker.OnFruitClicked += CallAchievement;
        private void OnDisable() => FruitClicker.OnFruitClicked -= CallAchievement;

        private void CallAchievement(string achievementName)
        {
            string key = $"achievement-{achievementName}";

            if (PlayerPrefs.GetInt(key) == 1)
                return;

            PlayerPrefs.SetInt(key, 1);
            Debug.Log($"<color=blue>Achievement Unlocked!</color> <color=yellow>{achievementName}</color>");
        }
    }
}