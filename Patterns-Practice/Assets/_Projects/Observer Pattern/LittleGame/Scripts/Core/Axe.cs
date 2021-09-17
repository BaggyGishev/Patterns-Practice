using Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Core
{
    public class Axe : Subject
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Notify("Warrior", NotificationType.AchievementUnlocked);

                var player = other.GetComponent<PlayerController>();
                player.GetArmed();

                Destroy(gameObject);
            }
        }
    }
}