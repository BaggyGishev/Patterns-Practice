using System.Collections;
using UnityEngine;

namespace Gisha.PatternsPractice.StrategyPattern
{
    public abstract class Shape : MonoBehaviour
    {
        protected MotionBehaviour _motionBehaviour;
        protected ColorBehaviour _colorBehaviour;

        private Rigidbody _rb;
        private MeshRenderer _mr;

        private void Awake()
        {
            _mr = GetComponent<MeshRenderer>();
            _rb = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            StartCoroutine(FiveSecondsCoroutine());
        }

        private IEnumerator FiveSecondsCoroutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(5f);

                SayYourName();
                PerformMotion();
                PerformColorChange();
            }
        }

        // General method.
        private void SayYourName()
        {
            Debug.Log($"My name is <color=blue>{gameObject.name}</color>");
        }

        // Changeable methods.
        private void PerformMotion()
        {
            _motionBehaviour.DoMotion(_rb);
        }

        private void PerformColorChange()
        {
            _colorBehaviour.DoColorChange(_mr.material);
        }
    }
}