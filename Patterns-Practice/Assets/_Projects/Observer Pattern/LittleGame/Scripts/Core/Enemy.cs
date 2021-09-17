using Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Core
{
    public class Enemy : Subject
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (other.GetComponent<PlayerController>().IsArmed)
                {
                    Destroy(gameObject);
                    Notify("Killer", NotificationType.AchievementUnlocked);
                }
                else
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}