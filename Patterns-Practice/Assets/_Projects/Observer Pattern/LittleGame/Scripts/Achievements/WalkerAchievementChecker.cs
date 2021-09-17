using System;
using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Achievements
{
    public class WalkerAchievementChecker : Subject
    {
        private float _meterCounted;
        private Vector3 _lastPos;

        private void Start()
        {
            if (PlayerPrefs.HasKey("Walker") && PlayerPrefs.GetInt("Walker") == 1)
                Destroy(this);
            
            _lastPos = transform.position;
        }

        private void Update()
        {
            _meterCounted += Vector3.Distance(_lastPos, transform.position);
            if (Math.Abs(_meterCounted) > 10)
            {
                Notify("Walker", NotificationType.AchievementUnlocked);
                Destroy(this);
            }
        }

        private void LateUpdate()
        {
            _lastPos = transform.position;
        }
    }
}