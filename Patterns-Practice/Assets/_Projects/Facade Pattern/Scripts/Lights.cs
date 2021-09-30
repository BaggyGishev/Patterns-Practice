using UnityEngine;

namespace Gisha.PatternsPractice.FacadePattern
{
    public class Lights : MonoBehaviour, IActiveable
    {
        private Light _light;

        private void Awake()
        {
            _light = GetComponent<Light>();
            _light.enabled = false;
        }

        public void Activate()
        {
            _light.enabled = true;
        }

        public void Deactivate()
        {
            _light.enabled = false;
        }
    }
}