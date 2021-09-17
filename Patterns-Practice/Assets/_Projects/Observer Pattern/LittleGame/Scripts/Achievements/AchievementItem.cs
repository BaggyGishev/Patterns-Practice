using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements
{
    public class AchievementItem : Subject
    {
        [SerializeField] private string achievementName;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Notify(achievementName, NotificationType.AchievementUnlocked);
                Destroy(gameObject);
            }
        }
    }
}