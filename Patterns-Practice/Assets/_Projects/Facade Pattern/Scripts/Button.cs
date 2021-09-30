using System;
using UnityEngine;

namespace Gisha.PatternsPractice.FacadePattern
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private GameObject[] _activeableObjects;
        private IActiveable[] _activeables;

        private void Start()
        {
            _activeables = new IActiveable[_activeableObjects.Length];

            for (var i = 0; i < _activeables.Length; i++)
                _activeables[i] = _activeableObjects[i].GetComponent<IActiveable>();
        }

        private void OnTriggerEnter(Collider other)
        {
            foreach (var activeable in _activeables)
                activeable.Activate();
        }

        private void OnTriggerExit(Collider other)
        {
            foreach (var activeable in _activeables)
                activeable.Deactivate();
        }
    }
}