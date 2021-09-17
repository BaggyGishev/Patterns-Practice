using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements
{
    public class AchievementSystem : Observer
    {
        private void Awake()
        {
            Subject[] subjects = FindObjectsOfType<Subject>();
            foreach (var subject in subjects)
                subject.RegisterObserver(this);

            //PlayerPrefs.DeleteAll();
        }

        public override void OnNotify(object value, NotificationType notificationType)
        {
            if (notificationType == NotificationType.AchievementUnlocked)
            {
                string achievementKey = value as string;

                if (PlayerPrefs.HasKey(achievementKey) && PlayerPrefs.GetInt(achievementKey) == 1)
                    return;

                PlayerPrefs.SetInt(achievementKey, 1);
                Debug.Log(
                    $"<color=yellow>Congratulations!</color> You've unlocked <color=red>{achievementKey}</color> achievement!");
            }
        }
    }
}