using System.Collections;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements
{
    public class FiveSecondsAchievementChecker : Subject
    {
        private void Start()
        {
            if (PlayerPrefs.HasKey("Player") && PlayerPrefs.GetInt("Player") == 1)
                Destroy(this);

            StartCoroutine(FiveSecondsTimerCoroutine());
        }

        private IEnumerator FiveSecondsTimerCoroutine()
        {
            yield return new WaitForSeconds(5f);
            Notify("Player", NotificationType.AchievementUnlocked);
        }
    }
}